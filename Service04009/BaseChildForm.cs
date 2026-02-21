using System.Drawing;
using System.Windows.Forms;

namespace Service04009
{
    /// <summary>
    /// Classe base para todos os formulários filhos do MainForm.
    /// Aplica automaticamente: double buffering, tema visual, AutoScroll.
    /// Todos os formulários de atirador e escala devem herdar desta classe.
    /// </summary>
    public class BaseChildForm : Form
    {
        public BaseChildForm()
        {
            // Double buffering elimina o flicker e renderiza tudo de uma vez
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        /// <summary>
        /// Após o InitializeComponent() do form filho, aplica o tema a todos os controles.
        /// Chamado automaticamente quando o form é mostrado pela primeira vez.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Suspende o layout para aplicar tudo de uma vez (evita flicker)
            SuspendLayout();
            try
            {
                AppTheme.ApplyFormTheme(this);
                AppTheme.ApplyThemeToAllControls(this);
            }
            finally
            {
                ResumeLayout(true);
            }
        }
    }
}
