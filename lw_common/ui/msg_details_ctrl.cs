﻿/* 
 * Copyright (C) 2014-2015 John Torjo
 *
 * This file is part of LogWizard
 *
 * LogWizard is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * LogWizard is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 * If you wish to use this code in a closed source application, please contact john.code@torjo.com
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lw_common.ui;

namespace lw_common {
    public partial class msg_details_ctrl : UserControl {
        private const int MAX_HEIGHT = 160;
        private Form wizard_parent_;

        private log_view_item_draw_ui drawer_;
        private print_info default_print_ = new print_info();

        public msg_details_ctrl(Form wizard_parent) {
            wizard_parent_ = wizard_parent;
            Debug.Assert(wizard_parent is log_view_parent);

            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
            Visible = true;
            show(false);
        }

        private int text_height(string txt, int width) {
            // I approximate here - since the txt control is a bit les than the whole user control, and we also need to account for the vertical scroll bar
            width -= 30;

            using (Graphics g = CreateGraphics()) {
                const int ignore_height = 500;
                var size = g.MeasureString(txt, this.txt.Font, new SizeF(width, ignore_height), new StringFormat(StringFormatFlags.DirectionRightToLeft));
                return (int)(size.Height * 1.15 + .95);
            }
        }

        private bool can_text_fit_in_width(string txt, int width) {
            int PAD_WIDTH = 300;
            using (Graphics g = CreateGraphics()) {
                const int ignore_height = 500;
                var size = g.MeasureString(txt, this.txt.Font, new SizeF(width + PAD_WIDTH, ignore_height), 
                    new StringFormat(StringFormatFlags.DirectionRightToLeft | StringFormatFlags.NoWrap));
                return size.Width <= width;
            }
            
        }

        public void update(log_view view, int top_offset, int bottom_offset, bool force_update) {
            Rectangle wizard_rect = (wizard_parent_ as log_view_parent).client_rect_no_filter; 
            Rectangle wizard_screen = wizard_parent_.RectangleToScreen(wizard_rect);
            // ... care about the lower buttons
            wizard_rect.Y += top_offset;
            wizard_rect.Height -= bottom_offset + top_offset;

            string sel = view.sel_line_text;
            if (sel == "") {
                show(false);
                return;
            }
            if (sel == txt.Text && !force_update)
                return; // nothing changed
            int height_offset = 10;
            var new_size = new Size( wizard_rect.Width, Math.Min( text_height(sel, wizard_rect.Width) + height_offset, MAX_HEIGHT) );
            Size = new_size;

            Rectangle line_rect = view.sel_rect_screen;
            if (can_text_fit_in_width(sel, line_rect.Width)) {
                show(false);
                return;
            }
            int distance_to_top = line_rect.Top - wizard_screen.Top;
            int distance_to_bottom = wizard_screen.Bottom - line_rect.Bottom;

            bool on_top = distance_to_top >= distance_to_bottom;
            var new_location = new Point(wizard_rect.Left, on_top ? wizard_rect.Top : wizard_rect.Bottom - Height);

            set_text(view);            
            show(true, new_location);
        }

        private void set_text(log_view lv) {
            if ( drawer_ == null)
                drawer_= new log_view_item_draw_ui(lv) { ignore_selection = true };
            drawer_.set_parent(lv);

            int msg_col = lv.msgCol.Index;
            string msg_txt = lv.sel_line_text;

            txt.Clear();
            txt.AppendText(msg_txt);

            var prints = lv.sel.override_print(lv, msg_txt, msg_col);
            var full_row = lv.list.GetItem(lv.sel_row_idx);

            txt.BackColor = drawer_.bg_color(full_row, msg_col);
            int last_idx = 0;

            for (int print_idx = 0; print_idx < prints.Count; ++print_idx) {
                int cur_idx = prints[print_idx].Item1, cur_len = prints[print_idx].Item2;
                string before = msg_txt.Substring(last_idx, cur_idx - last_idx);
                if (before != "") {
                    txt.Select(last_idx, cur_idx - last_idx);
                    txt.SelectionColor = drawer_.print_fg_color(full_row, default_print_);
                    txt.SelectionBackColor = drawer_.bg_color(full_row, msg_col);
                }
                txt.Select(cur_idx, cur_len);
                txt.SelectionColor = drawer_.print_fg_color(full_row, prints[print_idx].Item3);
                txt.SelectionBackColor = drawer_.print_bg_color(full_row, prints[print_idx].Item3);
                last_idx = cur_idx + cur_len;
            }
            last_idx = prints.Count > 0 ? prints.Last().Item1 + prints.Last().Item2 : 0;
            if (last_idx < msg_txt.Length) {
                txt.Select(last_idx, msg_txt.Length - last_idx);
                txt.SelectionColor = drawer_.print_fg_color(full_row, default_print_);
                txt.SelectionBackColor = drawer_.bg_color(full_row, msg_col);
            }

            txt.SelectionStart = 0;
            txt.SelectionLength = 0;            
        }

        public bool visible() {
            return Location.X > -10000;
        }

        internal void show(bool do_show, Point p = default(Point) ) {
            if (do_show) {
                Location = p;
                BringToFront();
            } else
                Location = new Point(-100000, -100000);
        }
    }
}
