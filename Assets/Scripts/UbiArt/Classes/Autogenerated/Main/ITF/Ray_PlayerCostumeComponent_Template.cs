using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_PlayerCostumeComponent_Template : ActorComponent_Template {
		public Path newIconPath;
		public Vec3d newIconOffset;
		public StringID playerIDInfo;
		public StringID animLocked;
		public StringID animShown;
		public StringID animAvailable;
		public StringID animUsed;
		public Path fx;
		public Generic<PhysShape> shape;
		public Vec2d shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			newIconPath = s.SerializeObject<Path>(newIconPath, name: "newIconPath");
			newIconOffset = s.SerializeObject<Vec3d>(newIconOffset, name: "newIconOffset");
			playerIDInfo = s.SerializeObject<StringID>(playerIDInfo, name: "playerIDInfo");
			animLocked = s.SerializeObject<StringID>(animLocked, name: "animLocked");
			animShown = s.SerializeObject<StringID>(animShown, name: "animShown");
			animAvailable = s.SerializeObject<StringID>(animAvailable, name: "animAvailable");
			animUsed = s.SerializeObject<StringID>(animUsed, name: "animUsed");
			fx = s.SerializeObject<Path>(fx, name: "fx");
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			shapeOffset = s.SerializeObject<Vec2d>(shapeOffset, name: "shapeOffset");
		}
		public override uint? ClassCRC => 0x311111BB;
	}
}

