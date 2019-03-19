using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HideAndSeekComponent_Template : ActorComponent_Template {
		[Serialize("animHide"              )] public StringID animHide;
		[Serialize("animShow"              )] public StringID animShow;
		[Serialize("animCatched"           )] public StringID animCatched;
		[Serialize("animDown"              )] public StringID animDown;
		[Serialize("animBump"              )] public StringID animBump;
		[Serialize("animLanding"           )] public StringID animLanding;
		[Serialize("hideDuration"          )] public float hideDuration;
		[Serialize("showDuration"          )] public float showDuration;
		[Serialize("catchedMinDuration"    )] public float catchedMinDuration;
		[Serialize("delayBeforeShowTuto"   )] public float delayBeforeShowTuto;
		[Serialize("coefEndDownHide"       )] public float coefEndDownHide;
		[Serialize("coefEndDownShow"       )] public float coefEndDownShow;
		[Serialize("playerCrushShapeRadius")] public float playerCrushShapeRadius;
		[Serialize("playerCrushShapeOffset")] public Vector2 playerCrushShapeOffset;
		[Serialize("reverseBehaviour"      )] public bool reverseBehaviour;
		[Serialize("forceMovePosition"     )] public bool forceMovePosition;
		[Serialize("disableDrcInHide"      )] public bool disableDrcInHide;
		[Serialize("crushShapeUsed"        )] public bool crushShapeUsed;
		[Serialize("hideWhenPlayerDetected")] public bool hideWhenPlayerDetected;
		[Serialize("landingEnabled"        )] public bool landingEnabled;
		[Serialize("hitDuration"           )] public float hitDuration;
		[Serialize("hitDelay"              )] public float hitDelay;
		[Serialize("bounceMultiplier"      )] public float bounceMultiplier;
		[Serialize("hitShape"              )] public Generic<PhysShape> hitShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animHide));
			SerializeField(s, nameof(animShow));
			SerializeField(s, nameof(animCatched));
			SerializeField(s, nameof(animDown));
			SerializeField(s, nameof(animBump));
			SerializeField(s, nameof(animLanding));
			SerializeField(s, nameof(hideDuration));
			SerializeField(s, nameof(showDuration));
			SerializeField(s, nameof(catchedMinDuration));
			SerializeField(s, nameof(delayBeforeShowTuto));
			SerializeField(s, nameof(coefEndDownHide));
			SerializeField(s, nameof(coefEndDownShow));
			SerializeField(s, nameof(playerCrushShapeRadius));
			SerializeField(s, nameof(playerCrushShapeOffset));
			SerializeField(s, nameof(reverseBehaviour));
			SerializeField(s, nameof(forceMovePosition));
			SerializeField(s, nameof(disableDrcInHide));
			SerializeField(s, nameof(crushShapeUsed));
			SerializeField(s, nameof(hideWhenPlayerDetected));
			SerializeField(s, nameof(landingEnabled));
			SerializeField(s, nameof(hitDuration));
			SerializeField(s, nameof(hitDelay));
			SerializeField(s, nameof(bounceMultiplier));
			SerializeField(s, nameof(hitShape));
		}
		public override uint? ClassCRC => 0x17197FEF;
	}
}

