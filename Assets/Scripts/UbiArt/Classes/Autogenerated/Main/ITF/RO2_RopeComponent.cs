using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RopeComponent : GraphicComponent {
		[Serialize("useBeginTexture"          )] public bool useBeginTexture;
		[Serialize("useEndTexture"            )] public bool useEndTexture;
		[Serialize("rendererScaleMultiplier"  )] public float rendererScaleMultiplier;
		[Serialize("flipTexture"              )] public bool flipTexture;
		[Serialize("initIteration"            )] public bool initIteration;
		[Serialize("ignoreStims"              )] public bool ignoreStims;
		[Serialize("initLenth"                )] public float initLenth;
		[Serialize("force"                    )] public float force;
		[Serialize("rigidConstraintFactor"    )] public float rigidConstraintFactor;
		[Serialize("lengthFactor"             )] public float lengthFactor;
		[Serialize("edgeLength"               )] public float edgeLength;
		[Serialize("bezierSampling"           )] public uint bezierSampling;
		[Serialize("inverseCurveRenderer"     )] public bool inverseCurveRenderer;
		[Serialize("fadeTime"                 )] public float fadeTime;
		[Serialize("onCutEvent"               )] public Generic<Event> onCutEvent;
		[Serialize("sendEventOnce"            )] public bool sendEventOnce;
		[Serialize("beginBindType"            )] public RopeBind beginBindType;
		[Serialize("beginBindName"            )] public StringID beginBindName;
		[Serialize("snapEnd"                  )] public bool snapEnd;
		[Serialize("safeMargin"               )] public float safeMargin;
		[Serialize("resetOnCheckpoint"        )] public bool resetOnCheckpoint;
		[Serialize("disableAfterFadeOnRelease")] public bool disableAfterFadeOnRelease;
		[Serialize("wasCut"                   )] public bool wasCut;
		[Serialize("cutLength"                )] public float cutLength;
		[Serialize("beginBindType"            )] public Enum_beginBindType beginBindType;
		[Serialize("cutSender"                )] public uint cutSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(useBeginTexture));
					SerializeField(s, nameof(useEndTexture));
					SerializeField(s, nameof(rendererScaleMultiplier));
					SerializeField(s, nameof(flipTexture));
					SerializeField(s, nameof(initIteration));
					SerializeField(s, nameof(ignoreStims));
					SerializeField(s, nameof(initLenth));
					SerializeField(s, nameof(force));
					SerializeField(s, nameof(rigidConstraintFactor));
					SerializeField(s, nameof(lengthFactor));
					SerializeField(s, nameof(edgeLength));
					SerializeField(s, nameof(bezierSampling));
					SerializeField(s, nameof(inverseCurveRenderer));
					SerializeField(s, nameof(fadeTime));
					SerializeField(s, nameof(onCutEvent));
					SerializeField(s, nameof(sendEventOnce));
					SerializeField(s, nameof(beginBindType));
					SerializeField(s, nameof(beginBindName));
					SerializeField(s, nameof(snapEnd));
					SerializeField(s, nameof(safeMargin));
					SerializeField(s, nameof(resetOnCheckpoint));
					SerializeField(s, nameof(disableAfterFadeOnRelease));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(wasCut));
					SerializeField(s, nameof(cutLength));
					SerializeField(s, nameof(cutSender));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(useBeginTexture));
					SerializeField(s, nameof(useEndTexture));
					SerializeField(s, nameof(rendererScaleMultiplier));
					SerializeField(s, nameof(flipTexture));
					SerializeField(s, nameof(initIteration));
					SerializeField(s, nameof(ignoreStims));
					SerializeField(s, nameof(initLenth));
					SerializeField(s, nameof(force));
					SerializeField(s, nameof(rigidConstraintFactor));
					SerializeField(s, nameof(lengthFactor));
					SerializeField(s, nameof(edgeLength));
					SerializeField(s, nameof(bezierSampling));
					SerializeField(s, nameof(inverseCurveRenderer));
					SerializeField(s, nameof(fadeTime));
					SerializeField(s, nameof(onCutEvent));
					SerializeField(s, nameof(sendEventOnce));
					SerializeField(s, nameof(beginBindType));
					SerializeField(s, nameof(beginBindName));
					SerializeField(s, nameof(snapEnd));
					SerializeField(s, nameof(safeMargin));
					SerializeField(s, nameof(resetOnCheckpoint));
					SerializeField(s, nameof(disableAfterFadeOnRelease));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(wasCut));
					SerializeField(s, nameof(cutLength));
				}
			}
		}
		public enum RopeBind {
			[Serialize("RopeBind::Root"              )] Root = 0,
			[Serialize("RopeBind::BoneName"          )] BoneName = 1,
			[Serialize("RopeBind::ProceduralBoneName")] ProceduralBoneName = 2,
		}
		public enum Enum_beginBindType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xEA979020;
	}
}

