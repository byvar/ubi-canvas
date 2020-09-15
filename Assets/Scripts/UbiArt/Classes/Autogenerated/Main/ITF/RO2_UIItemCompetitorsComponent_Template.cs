using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UIItemCompetitorsComponent_Template : UIComponent_Template {
		public Path competitorActorPath;
		public float competitorOffset;
		public Path countryActorPath;
		public Path levelActorPath;
		public Vec3d countryOffset;
		public Vec3d levelOffset;
		public float backgroundBaseWidth;
		public float maxNameWidth;
		public Path beatenActorPath;
		public float beatenActorAngle;
		public Color currentPlayerBackgroundColor;
		public float timeBetweenAnim;
		public float beatenAnimTime;
		public float beatenAnimMaxScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			competitorActorPath = s.SerializeObject<Path>(competitorActorPath, name: "competitorActorPath");
			competitorOffset = s.Serialize<float>(competitorOffset, name: "competitorOffset");
			countryActorPath = s.SerializeObject<Path>(countryActorPath, name: "countryActorPath");
			levelActorPath = s.SerializeObject<Path>(levelActorPath, name: "levelActorPath");
			countryOffset = s.SerializeObject<Vec3d>(countryOffset, name: "countryOffset");
			levelOffset = s.SerializeObject<Vec3d>(levelOffset, name: "levelOffset");
			backgroundBaseWidth = s.Serialize<float>(backgroundBaseWidth, name: "backgroundBaseWidth");
			maxNameWidth = s.Serialize<float>(maxNameWidth, name: "maxNameWidth");
			beatenActorPath = s.SerializeObject<Path>(beatenActorPath, name: "beatenActorPath");
			beatenActorAngle = s.Serialize<float>(beatenActorAngle, name: "beatenActorAngle");
			currentPlayerBackgroundColor = s.SerializeObject<Color>(currentPlayerBackgroundColor, name: "currentPlayerBackgroundColor");
			timeBetweenAnim = s.Serialize<float>(timeBetweenAnim, name: "timeBetweenAnim");
			beatenAnimTime = s.Serialize<float>(beatenAnimTime, name: "beatenAnimTime");
			beatenAnimMaxScale = s.Serialize<float>(beatenAnimMaxScale, name: "beatenAnimMaxScale");
		}
		public override uint? ClassCRC => 0xCD08B3F9;
	}
}

