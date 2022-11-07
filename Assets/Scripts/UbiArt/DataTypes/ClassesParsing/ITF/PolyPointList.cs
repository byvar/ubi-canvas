using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class PolyPointList {
		public bool HasChangedLoop { get; set; }

		public void CheckLoop() {
			if (HasChangedLoop) {
				HasChangedLoop = false;
				var count = LocalPoints?.Count ?? 0;
				if (count >= 2) {
					if (Loop) {
						if (LocalPoints[count - 1].POS.x != LocalPoints[0].POS.x ||
							LocalPoints[count - 1].POS.y != LocalPoints[0].POS.y) {
							LocalPoints.Add(new PolyLineEdge() {
								POS = new Vec2d(LocalPoints[0].POS.x, LocalPoints[0].POS.y),
							});
						}
					} else {
						if (count != 2) LocalPoints.RemoveAt(count - 1);
					}
				}
			}
		}

		public void RecomputeData() {
			var count = LocalPoints?.Count ?? 0;
			if (count != 0) {
				if (count > 2 && Loop) {
					LocalPoints[count - 1].POS = LocalPoints[0].POS;
				}
				Length = 0;
				for (int i = 0; i < count - 1; i++) {
					UpdateDataAt(i);
					Length += LocalPoints[i].Length;
				}
			}
		}

		public void UpdateDataAt(int i) {
			var pt = LocalPoints[i];
			if (i + 1 == LocalPoints?.Count && i + 1 > 2 && Loop) {
				pt.Vector = Vec2d.Zero;
				pt.Length = 0;
				pt.NormalizedVector = Vec2d.Zero;
			} else {
				var vec = LocalPoints[i + 1].POS - pt.POS;
				pt.Vector = vec;
				pt.Length = (float)vec.Magnitude;
				LocalPoints[i].NormalizedVector = pt.Length != 0 ? new Vec2d(vec.x / pt.Length, vec.y / pt.Length) : Vec2d.Zero;
			}
		}
	}
}
