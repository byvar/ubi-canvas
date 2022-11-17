using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class Frise {
		public class RecomputeData {
			public Frise Frise { get; }
			public FriseConfig Config { get; }

			public float HeightTimesThickness { get; set; } = 2;
			public float WidthTimesThickness { get; set; } = 2;
			public float OneOverAbsHeightTimesThickness { get; set; }
			public float ZExtrudeUp { get; set; }
			public float ZExtrudeDown { get; set; }
			public float Flexibility { get; set; }

			public bool FlipUV_X { get; set; }

			List<EdgeFrieze> EdgeFrieze { get; set; }


			public RecomputeData(Frise frise) {
				Frise = frise;
				Config = frise.config?.obj;
				if(Config == null) return;

				FlipUV_X = Frise.UvX_Flip ^ Config.isUvFlipX;
				HeightTimesThickness = Config.height * Frise.Thickness;
				WidthTimesThickness = Config.width * Frise.Thickness;
				ZExtrudeDown = Config.zExtrudeDown;
				ZExtrudeUp = Config.zExtrudeUp;
				Flexibility = Config.flexibility;

				// Todo: More in initDatas

				EdgeFrieze = new List<EdgeFrieze>();
			}

			public void CopyEdgesFromPolyline() {
				var points = Frise.PointsList.LocalPoints;
				for (int i = 0; i < points.Count - 1; i++) {
					EdgeFrieze.Add(new EdgeFrieze(this, points[i], points[i + 1]));
				}
			}

			public bool BuildEdgeListInSkew() {
				if (Config.skewAngle > 0x7149F2CA) return false;

				Vec2d skew = Vec2d.Right.Rotate(Config.skewAngle);
				// TODO
				foreach(var edge in EdgeFrieze) {
					edge.BuildEdgePoints(Config);
				}
				return true;
			}
		}
	}
}
