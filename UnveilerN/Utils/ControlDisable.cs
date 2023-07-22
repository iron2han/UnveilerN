using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnveilerN.Utils
{
    internal sealed class ControlDisable : IDisposable
    {
        private readonly Control _control;
        private readonly bool _enable;

        public ControlDisable(Control control)
        {
            _control = control ?? throw new ArgumentNullException(nameof(control));
            _enable = control.Enabled;
            control.Enabled = false;
        }

        public void Dispose()
        {
            _control.Enabled = _enable;
        }
    }
}
