namespace SecondCuitRun
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// StartApplication - Use 'StartApplicationParams' to pass parameters into this method.
        /// </summary>
        public void StartApplication()
        {

            // Launch '%USERPROFILE%\Documents\Visual Studio 2015\Projects\TestsettingDoublication\TestTarget\bin\Debug\TestTarget.exe'
            ApplicationUnderTest uITestTargetVerknüpfunWindow = ApplicationUnderTest.Launch(this.StartApplicationParams.UITestTargetVerknüpfunWindowExePath, this.StartApplicationParams.UITestTargetVerknüpfunWindowAlternateExePath);
        }

        public virtual StartApplicationParams StartApplicationParams
        {
            get
            {
                if ((this.mStartApplicationParams == null))
                {
                    this.mStartApplicationParams = new StartApplicationParams();
                }
                return this.mStartApplicationParams;
            }
        }

        private StartApplicationParams mStartApplicationParams;
    }
    /// <summary>
    /// Parameters to be passed into 'StartApplication'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class StartApplicationParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Documents\Visual Studio 2015\Projects\TestsettingDoublication\TestTarget\bin\Debug\TestTarget.exe'
        /// </summary>
        public string UITestTargetVerknüpfunWindowExePath = ".\\TestTarget.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\Documents\Visual Studio 2015\Projects\TestsettingDoublication\TestTarget\bin\Debug\TestTarget.exe'
        /// </summary>
        public string UITestTargetVerknüpfunWindowAlternateExePath = ".\\TestTarget.exe";
        #endregion
    }
}
