using System.Drawing;
using System.Windows.Forms;

namespace Service04009
{
    /// <summary>
    /// Classe estática centralizada com todas as definições de tema visual do aplicativo.
    /// Padroniza cores, fontes e estilos de componentes para uso em todos os formulários.
    /// </summary>
    public static class AppTheme
    {
        // ── Cores principais ────────────────────────────────────────────
        public static readonly Color BackgroundColor = Color.FromArgb(225, 240, 225);  // Verde claro suave
        public static readonly Color PanelBackground = Color.FromArgb(215, 232, 215);  // Painéis
        public static readonly Color AccentColor = Color.FromArgb(0, 130, 60);         // Verde escuro moderno
        public static readonly Color AccentLight = Color.FromArgb(0, 170, 80);         // Verde médio
        public static readonly Color AccentDark = Color.FromArgb(0, 100, 50);          // Verde mais escuro
        public static readonly Color SurfaceColor = Color.FromArgb(245, 250, 245);     // Superfícies/cards
        public static readonly Color SurfaceLight = Color.FromArgb(235, 245, 235);     // Superfícies hover
        public static readonly Color BorderColor = Color.FromArgb(180, 200, 180);      // Bordas
        public static readonly Color DangerColor = Color.FromArgb(220, 50, 50);        // Erros/remover
        public static readonly Color WarningColor = Color.FromArgb(255, 180, 0);       // Avisos
        public static readonly Color SuccessColor = Color.FromArgb(0, 180, 80);        // Sucesso

        // ── Cores de texto ──────────────────────────────────────────────
        public static readonly Color TextPrimary = Color.FromArgb(30, 40, 30);
        public static readonly Color TextSecondary = Color.FromArgb(80, 100, 80);
        public static readonly Color TextOnAccent = Color.White;

        // ── Cores do menu ───────────────────────────────────────────────
        public static readonly Color MenuBarColor = Color.FromArgb(0, 110, 55);        // Barra do menu
        public static readonly Color MenuItemColor = Color.FromArgb(240, 248, 240);    // Itens dropdown
        public static readonly Color MenuItemHover = Color.FromArgb(200, 230, 200);    // Hover nos itens

        // ── Fontes ──────────────────────────────────────────────────────
        public static readonly Font FontTitle = new Font("Segoe UI", 22F, FontStyle.Bold);
        public static readonly Font FontSubtitle = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font FontLabel = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static readonly Font FontLabelBold = new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font FontButton = new Font("Segoe UI", 12F, FontStyle.Bold);
        public static readonly Font FontButtonSmall = new Font("Segoe UI", 9F, FontStyle.Bold);
        public static readonly Font FontInput = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static readonly Font FontGrid = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font FontGridHeader = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font FontInfo = new Font("Segoe UI", 12F, FontStyle.Regular);

        // ── Métodos de estilização ──────────────────────────────────────

        /// <summary>
        /// Aplica o tema padrão a um formulário filho (sem borda, fundo escuro, autoScroll).
        /// </summary>
        public static void ApplyFormTheme(Form form)
        {
            form.BackgroundImage = null;
            form.BackColor = BackgroundColor;
            form.ForeColor = TextPrimary;
            form.Font = FontLabel;
            form.AutoScroll = true;
            form.Padding = new Padding(20);
        }

        /// <summary>
        /// Estiliza um Label como título principal do formulário.
        /// </summary>
        public static void StyleTitle(Label label)
        {
            label.Font = FontTitle;
            label.ForeColor = TextPrimary;
            label.BackColor = Color.Transparent;
            label.BorderStyle = BorderStyle.None;
            label.AutoSize = true;
            label.Padding = new Padding(0, 5, 0, 15);
        }

        /// <summary>
        /// Estiliza um Label como rótulo de campo.
        /// </summary>
        public static void StyleFieldLabel(Label label)
        {
            label.Font = FontLabelBold;
            label.ForeColor = TextPrimary;
            label.BackColor = Color.Transparent;
            label.AutoSize = true;
            label.Padding = new Padding(0, 5, 0, 2);
        }

        /// <summary>
        /// Estiliza um Label de informação (status/resultado).
        /// </summary>
        public static void StyleInfoLabel(Label label, bool success = true)
        {
            label.Font = FontInfo;
            label.ForeColor = TextOnAccent;
            label.BackColor = success ? AccentColor : DangerColor;
            label.Padding = new Padding(10, 5, 10, 5);
            label.AutoSize = true;
        }

        /// <summary>
        /// Estiliza um TextBox padrão.
        /// </summary>
        public static void StyleTextBox(TextBox textBox)
        {
            textBox.Font = FontInput;
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.FromArgb(30, 30, 30);
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Estiliza um Button como ação principal (cadastrar, confirmar).
        /// </summary>
        public static void StylePrimaryButton(Button button)
        {
            button.Font = FontButton;
            button.BackColor = AccentColor;
            button.ForeColor = TextOnAccent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = AccentLight;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.MouseOverBackColor = AccentLight;
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(15, 8, 15, 8);
            button.AutoSize = true;
        }

        /// <summary>
        /// Estiliza um Button como ação secundária (buscar, limpar).
        /// </summary>
        public static void StyleSecondaryButton(Button button)
        {
            button.Font = FontButtonSmall;
            button.BackColor = Color.White;
            button.ForeColor = TextPrimary;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = BorderColor;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.MouseOverBackColor = SurfaceLight;
            button.Cursor = Cursors.Hand;
            button.AutoSize = true;
        }

        /// <summary>
        /// Estiliza um Button como ação de perigo (remover, excluir).
        /// </summary>
        public static void StyleDangerButton(Button button)
        {
            button.Font = FontButton;
            button.BackColor = DangerColor;
            button.ForeColor = TextOnAccent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 80);
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 80, 80);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(15, 8, 15, 8);
            button.AutoSize = true;
        }

        /// <summary>
        /// Estiliza um CheckBox com aparência de botão toggle (CFC sim/não).
        /// </summary>
        public static void StyleToggleCheckBox(CheckBox checkBox)
        {
            checkBox.Appearance = Appearance.Button;
            checkBox.Font = FontButtonSmall;
            checkBox.BackColor = Color.White;
            checkBox.ForeColor = TextPrimary;
            checkBox.FlatStyle = FlatStyle.Flat;
            checkBox.FlatAppearance.BorderColor = BorderColor;
            checkBox.FlatAppearance.CheckedBackColor = AccentColor;
            checkBox.AutoSize = true;
            checkBox.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Estiliza um CheckBox de disponibilidade (manhã/noite).
        /// </summary>
        public static void StyleAvailabilityCheckBox(CheckBox checkBox)
        {
            checkBox.Font = FontButtonSmall;
            checkBox.BackColor = Color.White;
            checkBox.ForeColor = TextPrimary;
            checkBox.FlatStyle = FlatStyle.Flat;
            checkBox.FlatAppearance.BorderColor = BorderColor;
            checkBox.FlatAppearance.CheckedBackColor = AccentColor;
            checkBox.Appearance = Appearance.Button;
            checkBox.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Estiliza um DateTimePicker.
        /// </summary>
        public static void StyleDateTimePicker(DateTimePicker picker)
        {
            picker.Font = FontInput;
            picker.CalendarForeColor = TextPrimary;
            picker.CalendarMonthBackground = SurfaceColor;
        }

        /// <summary>
        /// Estiliza um DataGridView completo com o tema padrão.
        /// </summary>
        public static void StyleDataGridView(DataGridView grid)
        {
            // Preservar configurações funcionais definidas no Designer de cada form
            bool wasReadOnly = grid.ReadOnly;
            var editMode = grid.EditMode;
            var selectionMode = grid.SelectionMode;
            var autoSizeCols = grid.AutoSizeColumnsMode;

            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.BackgroundColor = Color.White;
            grid.GridColor = Color.FromArgb(210, 210, 210);
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Restaurar configurações funcionais (não são visuais, variam por form)
            grid.ReadOnly = wasReadOnly;
            grid.EditMode = editMode;
            grid.SelectionMode = selectionMode;
            if (autoSizeCols != DataGridViewAutoSizeColumnsMode.None)
                grid.AutoSizeColumnsMode = autoSizeCols;

            // Header
            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = AccentColor,
                ForeColor = TextOnAccent,
                Font = FontGridHeader,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(5),
                WrapMode = DataGridViewTriState.False,
            };

            // Células padrão
            grid.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(30, 30, 30),
                Font = FontGrid,
                SelectionBackColor = AccentColor,
                SelectionForeColor = Color.White,
                Padding = new Padding(5, 3, 5, 3),
                WrapMode = DataGridViewTriState.False,
            };

            // Linhas alternadas
            grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 245, 240),
                ForeColor = Color.FromArgb(30, 30, 30),
                SelectionBackColor = AccentColor,
                SelectionForeColor = Color.White,
            };

            // Row headers (caso visíveis)
            grid.RowHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(80, 80, 80),
            };
        }

        /// <summary>
        /// Aplica o tema recursivamente a todos os controles do formulário,
        /// detectando automaticamente o tipo de cada controle.
        /// </summary>
        public static void ApplyThemeToAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                switch (ctrl)
                {
                    case DataGridView grid:
                        StyleDataGridView(grid);
                        break;

                    case Button btn:
                        // Classifica botões pelo nome: remover/excluir = danger, query/buscar = secondary, resto = primary
                        string name = btn.Name.ToLower();
                        if (name.Contains("remov") || name.Contains("exclu") || name.Contains("delet"))
                            StyleDangerButton(btn);
                        else if (name.Contains("query") || name.Contains("limp") || name.Contains("busc"))
                            StyleSecondaryButton(btn);
                        else
                            StylePrimaryButton(btn);
                        break;

                    case TextBox tb:
                        StyleTextBox(tb);
                        break;

                    case CheckBox cb:
                        string cbName = cb.Name.ToLower();
                        if (cbName.Contains("cfc"))
                            StyleToggleCheckBox(cb);
                        else
                            StyleAvailabilityCheckBox(cb);
                        break;

                    case DateTimePicker dtp:
                        StyleDateTimePicker(dtp);
                        break;

                    case Label lbl:
                        string lblName = lbl.Name.ToLower();
                        if (lblName == "label1") // Título principal do form
                            StyleTitle(lbl);
                        else if (lblName.Contains("info"))
                            StyleInfoLabel(lbl);
                        else
                            StyleFieldLabel(lbl);
                        break;
                }

                // Recursão para containers (GroupBox, Panel, etc.)
                if (ctrl.HasChildren && ctrl is not DataGridView)
                {
                    ApplyThemeToAllControls(ctrl);
                }
            }
        }

        /// <summary>
        /// Aplica o tema ao MenuStrip principal e todos os seus itens, incluindo um renderer personalizado.
        /// </summary>
        public static void StyleMenuStrip(MenuStrip menu)
        {
            menu.BackColor = MenuBarColor;
            menu.ForeColor = TextOnAccent;
            menu.Renderer = new CleanMenuRenderer();
            foreach (ToolStripItem item in menu.Items)
            {
                item.ForeColor = TextOnAccent;
                item.BackColor = MenuBarColor;
                if (item is ToolStripMenuItem menuItem)
                    StyleMenuItemRecursive(menuItem, true);
            }
        }

        private static void StyleMenuItemRecursive(ToolStripMenuItem item, bool isTopLevel)
        {
            if (!isTopLevel)
            {
                item.BackColor = MenuItemColor;
                item.ForeColor = TextPrimary;
            }
            foreach (ToolStripItem child in item.DropDownItems)
            {
                if (child is ToolStripMenuItem subItem)
                {
                    subItem.BackColor = MenuItemColor;
                    subItem.ForeColor = TextPrimary;
                    StyleMenuItemRecursive(subItem, false);
                }
            }
        }
    }

    /// <summary>
    /// Renderer personalizado para o menu com visual limpo verde.
    /// </summary>
    internal class CleanMenuRenderer : ToolStripProfessionalRenderer
    {
        public CleanMenuRenderer() : base(new CleanMenuColorTable()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var item = e.Item;
            var g = e.Graphics;
            var rect = new Rectangle(Point.Empty, item.Size);

            if (item.Selected || item.Pressed)
            {
                bool isTopLevel = item.OwnerItem == null;
                Color hoverColor = isTopLevel
                    ? AppTheme.AccentLight
                    : AppTheme.MenuItemHover;
                using var brush = new SolidBrush(hoverColor);
                g.FillRectangle(brush, rect);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }

    internal class CleanMenuColorTable : ProfessionalColorTable
    {
        public override Color MenuStripGradientBegin => AppTheme.MenuBarColor;
        public override Color MenuStripGradientEnd => AppTheme.MenuBarColor;
        public override Color MenuItemSelected => AppTheme.MenuItemHover;
        public override Color MenuItemBorder => AppTheme.AccentColor;
        public override Color MenuBorder => AppTheme.BorderColor;
        public override Color MenuItemSelectedGradientBegin => AppTheme.MenuItemHover;
        public override Color MenuItemSelectedGradientEnd => AppTheme.MenuItemHover;
        public override Color MenuItemPressedGradientBegin => AppTheme.AccentLight;
        public override Color MenuItemPressedGradientEnd => AppTheme.AccentLight;
        public override Color ToolStripDropDownBackground => AppTheme.MenuItemColor;
        public override Color ImageMarginGradientBegin => AppTheme.MenuItemColor;
        public override Color ImageMarginGradientMiddle => AppTheme.MenuItemColor;
        public override Color ImageMarginGradientEnd => AppTheme.MenuItemColor;
        public override Color SeparatorDark => AppTheme.BorderColor;
        public override Color SeparatorLight => AppTheme.SurfaceLight;
    }
}
