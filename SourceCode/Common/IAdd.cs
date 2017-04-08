using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface IAdd
    {
        void PageLoad(object sender, EventArgs e);
        void SetButtons();
        void SetPageControlsValue();
        void Save(object sender, EventArgs e);
        void ResetControls();
        void Close();
    }
}
