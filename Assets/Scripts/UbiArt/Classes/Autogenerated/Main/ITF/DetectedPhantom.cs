using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DetectedPhantom : DetectedObject {
		public StringID PhantomDetectorID;
		public StringID PhantomID;
		public Vec2d ContactPoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags0)) {
				PhantomDetectorID = s.SerializeObject<StringID>(PhantomDetectorID, name: "PhantomDetectorID");
				PhantomID = s.SerializeObject<StringID>(PhantomID, name: "PhantomID");
				ContactPoint = s.SerializeObject<Vec2d>(ContactPoint, name: "ContactPoint");
			}
		}
		public override uint? ClassCRC => 0x9E71DB87;
	}
}

