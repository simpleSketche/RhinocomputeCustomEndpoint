using Rhino;
using Rhino.PlugIns;
using System;
using System.Windows.Input.StylusPlugIns;

namespace RhinoComputeCustomEndpoint
{
    ///<summary>
    /// <para>Every RhinoCommon .rhp assembly must have one and only one PlugIn-derived
    /// class. DO NOT create instances of this class yourself. It is the
    /// responsibility of Rhino to create an instance of this class.</para>
    /// <para>To complete plug-in information, please also see all PlugInDescription
    /// attributes in AssemblyInfo.cs (you might need to click "Project" ->
    /// "Show All Files" to see it in the "Solution Explorer" window).</para>
    ///</summary>
    public class RhinoComputeCustomEndpointPlugin : Rhino.PlugIns.PlugIn
    {
        public RhinoComputeCustomEndpointPlugin()
        {
            Instance = this;

            
        }

        ///<summary>Gets the only instance of the RhinoComputeCustomEndpointPlugin plug-in.</summary>
        public static RhinoComputeCustomEndpointPlugin Instance { get; private set; }

        // You can override methods here to change the plug-in behavior on
        // loading and shut down, add options pages to the Rhino _Option command
        // and maintain plug-in wide options in a document.
        public override PlugInLoadTime LoadTime => PlugInLoadTime.AtStartup;

        protected override LoadReturnCode OnLoad(ref string errorMessage)
        {
            Rhino.RhinoApp.WriteLine("Loading RhinoComputeCustomEndpoint");

            // register the endpoint
            Rhino.Runtime.HostUtils.RegisterComputeEndpoint("MDL", typeof(CustomEndpoints));

            return base.OnLoad(ref errorMessage);
        }
    }
}