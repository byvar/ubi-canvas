namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_HideAndSeekComponent_Template : ActorComponent_Template {
		public StringID animHide;
		public StringID animShow;
		public StringID animCatched;
		public StringID animDown;
		public StringID animBump;
		public StringID animLanding;
		public float hideDuration;
		public float showDuration;
		public float catchedMinDuration;
		public float delayBeforeShowTuto;
		public float coefEndDownHide;
		public float coefEndDownShow;
		public float playerCrushShapeRadius;
		public Vec2d playerCrushShapeOffset;
		public bool reverseBehaviour;
		public bool forceMovePosition;
		public bool disableDrcInHide;
		public bool crushShapeUsed;
		public bool hideWhenPlayerDetected;
		public bool landingEnabled;
		public float hitDuration;
		public float hitDelay;
		public float bounceMultiplier;
		public Generic<PhysShape> hitShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animHide = s.SerializeObject<StringID>(animHide, name: "animHide");
			animShow = s.SerializeObject<StringID>(animShow, name: "animShow");
			animCatched = s.SerializeObject<StringID>(animCatched, name: "animCatched");
			animDown = s.SerializeObject<StringID>(animDown, name: "animDown");
			animBump = s.SerializeObject<StringID>(animBump, name: "animBump");
			animLanding = s.SerializeObject<StringID>(animLanding, name: "animLanding");
			hideDuration = s.Serialize<float>(hideDuration, name: "hideDuration");
			showDuration = s.Serialize<float>(showDuration, name: "showDuration");
			catchedMinDuration = s.Serialize<float>(catchedMinDuration, name: "catchedMinDuration");
			delayBeforeShowTuto = s.Serialize<float>(delayBeforeShowTuto, name: "delayBeforeShowTuto");
			coefEndDownHide = s.Serialize<float>(coefEndDownHide, name: "coefEndDownHide");
			coefEndDownShow = s.Serialize<float>(coefEndDownShow, name: "coefEndDownShow");
			playerCrushShapeRadius = s.Serialize<float>(playerCrushShapeRadius, name: "playerCrushShapeRadius");
			playerCrushShapeOffset = s.SerializeObject<Vec2d>(playerCrushShapeOffset, name: "playerCrushShapeOffset");
			reverseBehaviour = s.Serialize<bool>(reverseBehaviour, name: "reverseBehaviour");
			forceMovePosition = s.Serialize<bool>(forceMovePosition, name: "forceMovePosition");
			disableDrcInHide = s.Serialize<bool>(disableDrcInHide, name: "disableDrcInHide");
			crushShapeUsed = s.Serialize<bool>(crushShapeUsed, name: "crushShapeUsed");
			hideWhenPlayerDetected = s.Serialize<bool>(hideWhenPlayerDetected, name: "hideWhenPlayerDetected");
			landingEnabled = s.Serialize<bool>(landingEnabled, name: "landingEnabled");
			hitDuration = s.Serialize<float>(hitDuration, name: "hitDuration");
			hitDelay = s.Serialize<float>(hitDelay, name: "hitDelay");
			bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
			hitShape = s.SerializeObject<Generic<PhysShape>>(hitShape, name: "hitShape");
		}
		public override uint? ClassCRC => 0x17197FEF;
	}
}

