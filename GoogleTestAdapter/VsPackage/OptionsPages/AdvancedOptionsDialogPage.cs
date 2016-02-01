﻿using System.ComponentModel;

namespace GoogleTestAdapter.VsPackage.OptionsPages
{

    public class AdvancedOptionsDialogPage : NotifyingDialogPage
    {
        [Category(Options.CategoryName)]
        [DisplayName(Options.OptionReportWaitPeriod)]
        [Description(Options.OptionReportWaitPeriodDescription)]
        public int ReportWaitPeriod
        {
            get { return reportWaitPeriod; }
            set { SetAndNotify(ref reportWaitPeriod, value); }
        }
        private int reportWaitPeriod = Options.OptionReportWaitPeriodDefaultValue;
    }

}