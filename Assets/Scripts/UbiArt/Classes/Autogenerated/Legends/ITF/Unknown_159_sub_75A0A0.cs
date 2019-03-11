using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_159_sub_75A0A0 : CSerializable {
		[Serialize("blinkScaleMin"                  )] public float blinkScaleMin;
		[Serialize("blinkScale"                     )] public float blinkScale;
		[Serialize("blinkPeriod"                    )] public float blinkPeriod;
		[Serialize("blinkMinBlendSpeed"             )] public float blinkMinBlendSpeed;
		[Serialize("hightlightAlphaMin"             )] public float hightlightAlphaMin;
		[Serialize("hightlightAlpha"                )] public float hightlightAlpha;
		[Serialize("hightlightPeriod"               )] public float hightlightPeriod;
		[Serialize("hightlightMinBlendSpeed"        )] public float hightlightMinBlendSpeed;
		[Serialize("margingIconX"                   )] public float margingIconX;
		[Serialize("activatingDuration"             )] public float activatingDuration;
		[Serialize("nameOffset"                     )] public float nameOffset;
		[Serialize("mainPlayerBackgroundColorFactor")] public Color mainPlayerBackgroundColorFactor;
		[Serialize("actorIconSelected"              )] public StringID actorIconSelected;
		[Serialize("actorIconOffset"                )] public Vector2 actorIconOffset;
		[Serialize("inverseShadowState"             )] public bool inverseShadowState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(blinkScaleMin));
			SerializeField(s, nameof(blinkScale));
			SerializeField(s, nameof(blinkPeriod));
			SerializeField(s, nameof(blinkMinBlendSpeed));
			SerializeField(s, nameof(hightlightAlphaMin));
			SerializeField(s, nameof(hightlightAlpha));
			SerializeField(s, nameof(hightlightPeriod));
			SerializeField(s, nameof(hightlightMinBlendSpeed));
			SerializeField(s, nameof(margingIconX));
			SerializeField(s, nameof(activatingDuration));
			SerializeField(s, nameof(nameOffset));
			SerializeField(s, nameof(mainPlayerBackgroundColorFactor));
			SerializeField(s, nameof(actorIconSelected));
			SerializeField(s, nameof(actorIconOffset));
			SerializeField(s, nameof(inverseShadowState));
		}
		public override uint? ClassCRC => 0x0D055EDD;
	}
}

