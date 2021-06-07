using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace CustomParameterEditorAspNetCoreExample.PredefinedReports
{
    public partial class TestReport
    {
        public TestReport()
        {
            InitializeComponent();

            var staticListLookUpSettings1 = new StaticListLookUpSettings();
            var staticListLookUpSettings2 = new StaticListLookUpSettings();
            // 
            // customMailParameterLookup
            // 
            customMailParameterLookup.Description = "Custom Email Parameter";
            customMailParameterLookup.Name = "customMailParameterLookup";
            customMailParameterLookup.Type = typeof(CustomParameterType);
            var parameterLookUpValue1 = new CustomParameterType { Value = "MyFirtsMail@example.com" };
            var parameterLookUpValue2 = new CustomParameterType { Value = "MySecondMail@example.com" };
            staticListLookUpSettings1.LookUpValues.AddRange(new List<LookUpValue> {
            new LookUpValue(parameterLookUpValue1, "First Mail Value"),
            new LookUpValue(parameterLookUpValue2, "Second Mail Value")
        });
            customMailParameterLookup.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // customMailParameterText
            // 
            customMailParameterText.Description = "Additional Custom Email Parameter";
            customMailParameterText.Name = "customMailParameterText";
            customMailParameterText.Type = typeof(CustomParameterType);
            customMailParameterText.Value = new CustomParameterType { Value = "SampleMail@example.com" };
            // 
            // customMailParameterMultivalue
            // 
            customMailParameterMultivalue.Description = "Multi-value Email Parameter";
            customMailParameterMultivalue.MultiValue = true;
            customMailParameterMultivalue.Name = "customMailParameterMultivalue";
            customMailParameterMultivalue.Type = typeof(CustomParameterType);
            customMailParameterMultivalue.Value = new List<CustomParameterType> {
            new CustomParameterType { Value = "FirstSampleMail@example.com" },
            new CustomParameterType { Value = "SecondSampleMail@example.com" }
        };
            // 
            // customMailParameterMultivalueLookup
            // 
            customMailParameterMultivalueLookup.Description = "Predefined multi-value Email parameter";
            customMailParameterMultivalueLookup.MultiValue = true;
            customMailParameterMultivalueLookup.Name = "customMailParameterMultivalueLookup";
            customMailParameterMultivalueLookup.Type = typeof(CustomParameterType);
            var parameterLookUpValue3 = new CustomParameterType { Value = "MyThirdMail@example.com" };
            var parameterLookUpValue4 = new CustomParameterType { Value = "MyFourthMail@example.com" };
            staticListLookUpSettings2.LookUpValues.AddRange(new List<LookUpValue> {
            new LookUpValue(parameterLookUpValue3, "Third Mail Value"),
            new LookUpValue(parameterLookUpValue4, "Fourth Mail Value")
        });
            customMailParameterMultivalueLookup.ValueSourceSettings = staticListLookUpSettings2;
        }

        private void tableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRTableCell).Text += " Customized";
        }
    }
}
