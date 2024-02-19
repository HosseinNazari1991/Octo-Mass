using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace OctoMass
{
    public class OctoMassInfo : GH_AssemblyInfo
    {
        public override string Name => "OctoMass";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("8aaca344-651e-4387-95f7-ab149772feeb");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}