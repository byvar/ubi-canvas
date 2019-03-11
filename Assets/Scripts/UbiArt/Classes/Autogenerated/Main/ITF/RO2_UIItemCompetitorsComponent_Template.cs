using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_UIItemCompetitorsComponent_Template : UIComponent_Template {
		[Serialize("competitorActorPath"         )] public Path competitorActorPath;
		[Serialize("competitorOffset"            )] public float competitorOffset;
		[Serialize("countryActorPath"            )] public Path countryActorPath;
		[Serialize("levelActorPath"              )] public Path levelActorPath;
		[Serialize("countryOffset"               )] public Vector3 countryOffset;
		[Serialize("levelOffset"                 )] public Vector3 levelOffset;
		[Serialize("backgroundBaseWidth"         )] public float backgroundBaseWidth;
		[Serialize("maxNameWidth"                )] public float maxNameWidth;
		[Serialize("beatenActorPath"             )] public Path beatenActorPath;
		[Serialize("beatenActorAngle"            )] public float beatenActorAngle;
		[Serialize("currentPlayerBackgroundColor")] public Color currentPlayerBackgroundColor;
		[Serialize("timeBetweenAnim"             )] public float timeBetweenAnim;
		[Serialize("beatenAnimTime"              )] public float beatenAnimTime;
		[Serialize("beatenAnimMaxScale"          )] public float beatenAnimMaxScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(competitorActorPath));
			SerializeField(s, nameof(competitorOffset));
			SerializeField(s, nameof(countryActorPath));
			SerializeField(s, nameof(levelActorPath));
			SerializeField(s, nameof(countryOffset));
			SerializeField(s, nameof(levelOffset));
			SerializeField(s, nameof(backgroundBaseWidth));
			SerializeField(s, nameof(maxNameWidth));
			SerializeField(s, nameof(beatenActorPath));
			SerializeField(s, nameof(beatenActorAngle));
			SerializeField(s, nameof(currentPlayerBackgroundColor));
			SerializeField(s, nameof(timeBetweenAnim));
			SerializeField(s, nameof(beatenAnimTime));
			SerializeField(s, nameof(beatenAnimMaxScale));
		}
		public override uint? ClassCRC => 0xCD08B3F9;
	}
}

