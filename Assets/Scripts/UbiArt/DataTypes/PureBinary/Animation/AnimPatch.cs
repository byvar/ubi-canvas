using System;

namespace UbiArt.Animation {
	// See: ITF::AnimPatch::serialize
	public class AnimPatch : CSerializable {
		public Link bankId;
		public uint templateIndex;
		public byte numPoints;
		public Link[] points = new Link[0];

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bankId = s.SerializeObject<Link>(bankId, name: "bankId");
			templateIndex = s.Serialize<uint>(templateIndex, name: "templateIndex");
			numPoints = s.Serialize<byte>(numPoints, name: "numPoints");
			if (points.Length != numPoints) {
				Array.Resize(ref points, numPoints);
			}
			for (int i = 0; i < numPoints; i++) {
				if (s.ArrayEntryStart(name: "points", index: i)) {
					points[i] = s.SerializeObject<Link>(points[i], name: "VAL");
					s.ArrayEntryStop();
				}
			}
		}

		/*
		Example (Legends):
		0AD026B0 00000000 3F2AC0833F0A0675 3C397212BF7FFBCE 10BDAF20BF2043C43EA0387E3622ED493F800000
		0AD026D8 00000001 3F2BB5F23F547E39 BC3972123F7FFBCE 10BDAF20BF13E671BE899696B622ED49BF800000
		0AD02700 00000002 3F71C28F3F089E67 3C397212BF7FFBCE 10BDAF203FA37B9E3EA90F733622ED493F800000
		0AD02728 00000003 3F6DE5C13F55562A BC3972123F7FFBCE 10BDAF203F993501BE89F773B622ED49BF800000
		*/

	}
}
