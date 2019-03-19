using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventTriggerChangePage : Event {
		[Serialize("enterPoint"     )] public Vector3 enterPoint;
		[Serialize("exitPoint"      )] public Vector3 exitPoint;
		[Serialize("finalPoint"     )] public Vector3 finalPoint;
		[Serialize("verticalEject"  )] public int verticalEject;
		[Serialize("destinationPage")] public uint destinationPage;
		[Serialize("playerDuration" )] public float playerDuration;
		[Serialize("useFade"        )] public int useFade;
		[Serialize("isCageDoor"     )] public int isCageDoor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterPoint));
			SerializeField(s, nameof(exitPoint));
			SerializeField(s, nameof(finalPoint));
			SerializeField(s, nameof(verticalEject));
			SerializeField(s, nameof(destinationPage));
			SerializeField(s, nameof(playerDuration));
			SerializeField(s, nameof(useFade));
			SerializeField(s, nameof(isCageDoor));
		}
		public override uint? ClassCRC => 0xD0CE9111;
	}
}

