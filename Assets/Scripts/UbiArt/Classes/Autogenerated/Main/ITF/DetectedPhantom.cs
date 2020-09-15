using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DetectedPhantom : DetectedObject {
		[Serialize("PhantomDetectorID")] public StringID PhantomDetectorID;
		[Serialize("PhantomID"        )] public StringID PhantomID;
		[Serialize("ContactPoint"     )] public Vec2d ContactPoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags0)) {
				SerializeField(s, nameof(PhantomDetectorID));
				SerializeField(s, nameof(PhantomID));
				SerializeField(s, nameof(ContactPoint));
			}
		}
		public override uint? ClassCRC => 0x9E71DB87;
	}
}

