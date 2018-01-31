using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ExtensionNumbersPath : PathSegment
    {
        internal ExtensionNumbersPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "extension-numbers";
            }
        }
    }
}
