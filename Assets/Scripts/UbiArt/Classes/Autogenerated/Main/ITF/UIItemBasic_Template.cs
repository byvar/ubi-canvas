using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIItemBasic_Template : UIItem_Template {
		[Serialize("blinkScaleMin"            )] public float blinkScaleMin;
		[Serialize("blinkScale"               )] public float blinkScale;
		[Serialize("blinkPeriod"              )] public float blinkPeriod;
		[Serialize("blinkMinBlendSpeed"       )] public float blinkMinBlendSpeed;
		[Serialize("hightlightAlphaMin"       )] public float hightlightAlphaMin;
		[Serialize("hightlightAlpha"          )] public float hightlightAlpha;
		[Serialize("hightlightPeriod"         )] public float hightlightPeriod;
		[Serialize("hightlightMinBlendSpeed"  )] public float hightlightMinBlendSpeed;
		[Serialize("activatingScale"          )] public float activatingScale;
		[Serialize("activatingDuration"       )] public float activatingDuration;
		[Serialize("activatingRebound"        )] public uint activatingRebound;
		[Serialize("animUnselected"           )] public StringID animUnselected;
		[Serialize("animSelected"             )] public StringID animSelected;
		[Serialize("animLocked"               )] public StringID animLocked;
		[Serialize("needSyncBlink"            )] public bool needSyncBlink;
		[Serialize("fontEffectUnselected"     )] public StringID fontEffectUnselected;
		[Serialize("fontEffectSelected"       )] public StringID fontEffectSelected;
		[Serialize("colorFactorSelected"      )] public Color colorFactorSelected;
		[Serialize("colorFactorLocked"        )] public Color colorFactorLocked;
		[Serialize("colorFactorUnselected"    )] public Color colorFactorUnselected;
		[Serialize("textLockedAlpha"          )] public float textLockedAlpha;
		[Serialize("animLockedAlpha"          )] public float animLockedAlpha;
		[Serialize("colorBlendTime"           )] public float colorBlendTime;
		[Serialize("ScaleUnselected"          )] public float ScaleUnselected;
		[Serialize("uvRotationSpeedSelected"  )] public Angle uvRotationSpeedSelected;
		[Serialize("uvRotationSpeedUnselected")] public Angle uvRotationSpeedUnselected;
		[Serialize("actorIconSelected"        )] public StringID actorIconSelected;
		[Serialize("actorIconUnselected"      )] public StringID actorIconUnselected;
		[Serialize("inverseShadowState"       )] public bool inverseShadowState;
		[Serialize("actorIconOffset"          )] public Vector2 actorIconOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(blinkScaleMin));
				SerializeField(s, nameof(blinkScale));
				SerializeField(s, nameof(blinkPeriod));
				SerializeField(s, nameof(blinkMinBlendSpeed));
				SerializeField(s, nameof(hightlightAlphaMin));
				SerializeField(s, nameof(hightlightAlpha));
				SerializeField(s, nameof(hightlightPeriod));
				SerializeField(s, nameof(hightlightMinBlendSpeed));
				SerializeField(s, nameof(activatingScale));
				SerializeField(s, nameof(activatingDuration));
				SerializeField(s, nameof(activatingRebound));
				SerializeField(s, nameof(animUnselected));
				SerializeField(s, nameof(animSelected));
				SerializeField(s, nameof(fontEffectUnselected));
				SerializeField(s, nameof(fontEffectSelected));
				SerializeField(s, nameof(colorFactorSelected));
				SerializeField(s, nameof(colorFactorUnselected));
				SerializeField(s, nameof(colorBlendTime));
				SerializeField(s, nameof(uvRotationSpeedSelected));
				SerializeField(s, nameof(uvRotationSpeedUnselected));
				SerializeField(s, nameof(actorIconSelected));
				SerializeField(s, nameof(actorIconUnselected));
				SerializeField(s, nameof(actorIconOffset));
				SerializeField(s, nameof(inverseShadowState));
			} else {
				SerializeField(s, nameof(blinkScaleMin));
				SerializeField(s, nameof(blinkScale));
				SerializeField(s, nameof(blinkPeriod));
				SerializeField(s, nameof(blinkMinBlendSpeed));
				SerializeField(s, nameof(hightlightAlphaMin));
				SerializeField(s, nameof(hightlightAlpha));
				SerializeField(s, nameof(hightlightPeriod));
				SerializeField(s, nameof(hightlightMinBlendSpeed));
				SerializeField(s, nameof(activatingScale));
				SerializeField(s, nameof(activatingDuration));
				SerializeField(s, nameof(activatingRebound));
				SerializeField(s, nameof(animUnselected));
				SerializeField(s, nameof(animSelected));
				SerializeField(s, nameof(animLocked));
				SerializeField(s, nameof(needSyncBlink));
				SerializeField(s, nameof(fontEffectUnselected));
				SerializeField(s, nameof(fontEffectSelected));
				SerializeField(s, nameof(colorFactorSelected));
				SerializeField(s, nameof(colorFactorLocked));
				SerializeField(s, nameof(colorFactorUnselected));
				SerializeField(s, nameof(textLockedAlpha));
				SerializeField(s, nameof(animLockedAlpha));
				SerializeField(s, nameof(colorBlendTime));
				SerializeField(s, nameof(ScaleUnselected));
				SerializeField(s, nameof(uvRotationSpeedSelected));
				SerializeField(s, nameof(uvRotationSpeedUnselected));
				SerializeField(s, nameof(actorIconSelected));
				SerializeField(s, nameof(actorIconUnselected));
				SerializeField(s, nameof(inverseShadowState));
			}
		}
		public override uint? ClassCRC => 0x7A821220;
	}
}

