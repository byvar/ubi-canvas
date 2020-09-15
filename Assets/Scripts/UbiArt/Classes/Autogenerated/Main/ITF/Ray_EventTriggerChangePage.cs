using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventTriggerChangePage : Event {
		public Vec3d enterPoint;
		public Vec3d exitPoint;
		public Vec3d finalPoint;
		public int verticalEject;
		public uint destinationPage;
		public float playerDuration;
		public int useFade;
		public int isCageDoor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enterPoint = s.SerializeObject<Vec3d>(enterPoint, name: "enterPoint");
			exitPoint = s.SerializeObject<Vec3d>(exitPoint, name: "exitPoint");
			finalPoint = s.SerializeObject<Vec3d>(finalPoint, name: "finalPoint");
			verticalEject = s.Serialize<int>(verticalEject, name: "verticalEject");
			destinationPage = s.Serialize<uint>(destinationPage, name: "destinationPage");
			playerDuration = s.Serialize<float>(playerDuration, name: "playerDuration");
			useFade = s.Serialize<int>(useFade, name: "useFade");
			isCageDoor = s.Serialize<int>(isCageDoor, name: "isCageDoor");
		}
		public override uint? ClassCRC => 0xD0CE9111;
	}
}

