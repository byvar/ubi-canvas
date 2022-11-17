namespace UbiArt.ITF {
	public partial class Frise {
		public class EdgeFrieze {
			public PolyLineEdge Edge { get; }
			public Vec2d AbsolutePosition { get; }
			public float Scale { get; }
			public float ScaleTimesHeightTimesThickness { get; }
			public Vec2d EdgeVector { get; }
			public Vec2d EdgeDirection { get; }
			public Vec2d EdgeNormal { get; }
			public float EdgeLength { get; set; }
			public float EdgeNormalScale { get; set; } = 1f;


			public Vec2d Point0_BottomLeft { get; set; } // Bottom left
			public Vec2d Point1_TopLeft { get; set; } // Top left
			public Vec2d Point2_BottomRight { get; set; } // Bottom right
			public Vec2d Point3_TopRight { get; set; } // Top right

			public EdgeFrieze(RecomputeData recomputeData, PolyLineEdge edge, PolyLineEdge nextEdge = null) {
				Edge = edge;
				AbsolutePosition = edge.POS;
				Scale = edge.Scale;
				ScaleTimesHeightTimesThickness = Scale * recomputeData.HeightTimesThickness;

				if (nextEdge != null) {
					EdgeVector = nextEdge.POS - AbsolutePosition;
					EdgeDirection = EdgeVector.Normalize();
					EdgeLength = (float)EdgeVector.Magnitude;
					EdgeNormal = new Vec2d(-EdgeDirection.y, EdgeDirection.x);
				}
			}

			public void BuildEdgePoints(FriseConfig config) {
				var visualOffset = config.visualOffset;
				var scaledNormal = EdgeNormal * EdgeNormalScale;
				var heightVector = EdgeNormal * ScaleTimesHeightTimesThickness;

				Point0_BottomLeft = AbsolutePosition - heightVector * visualOffset;
				Point1_TopLeft = Point0_BottomLeft + heightVector;
				Point2_BottomRight = AbsolutePosition + EdgeVector - scaledNormal * visualOffset;
				Point3_TopRight = Point2_BottomRight + scaledNormal;
			}
		}
	}
}
