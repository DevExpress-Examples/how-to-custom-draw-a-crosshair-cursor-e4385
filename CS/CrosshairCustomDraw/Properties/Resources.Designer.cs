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


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if ((resourceMan == null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrosshairCustomDraw.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
    }
}
