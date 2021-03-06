﻿// Developer Express Code Central Example:
// How to custom draw a crosshair cursor
// 
// This example shows how to provide custom appearance of the crosshair cursor
// using the ChartControl.CustomDrawCrosshair
// (http://help.devexpress.com/#WPF/DevExpressXpfChartsChartControl_CustomDrawCrosshairtopic)
// event. This event is invoked when you click the Custom Draw Crosshair Cursor
// button on the form. If you wish to display crosshair axis lines and labels on a
// chart before custom drawing the crosshair cursor, set the
// CrosshairOptions.ShowArgumentLabels
// (http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowArgumentLabelstopic),
// CrosshairOptions.ShowArgumentLine
// (http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowArgumentLinetopic),
// CrosshairOptions.ShowValueLabels
// (http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowValueLabelstopic)
// and CrosshairOptions.ShowValueLine
// (http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_ShowValueLinetopic)
// properties to true. Note that the customization of the crosshair cursor is
// provided for the CrosshairOptions.SnapMode
// (http://help.devexpress.com/#WPF/DevExpressXpfChartsCrosshairOptions_SnapModetopic)
// property set to NearestArgument.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4385

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrosshairCustomDraw.Properties {


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}
