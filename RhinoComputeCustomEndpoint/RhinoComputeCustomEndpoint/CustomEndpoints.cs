using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoComputeCustomEndpoint
{
    public static class CustomEndpoints
    {
        public static IEnumerable<PointContainment> CheckContainments(Curve closedCrv, IEnumerable<Point3d>pts)
        {
            List<PointContainment> result = new List<PointContainment>();

            foreach(Point3d pt in pts)
            {
                PointContainment containment = closedCrv.Contains(pt, Plane.WorldXY, 0.00000001);
                result.Add(containment);
            }

            return result.ToArray();
        }
    }
}
