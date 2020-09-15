using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RopeComponent : GraphicComponent {
		public bool useBeginTexture;
		public bool useEndTexture;
		public float rendererScaleMultiplier;
		public bool flipTexture;
		public bool initIteration;
		public bool ignoreStims;
		public float initLenth;
		public float force;
		public float rigidConstraintFactor;
		public float lengthFactor;
		public float edgeLength;
		public uint bezierSampling;
		public bool inverseCurveRenderer;
		public float fadeTime;
		public Generic<Event> onCutEvent;
		public bool sendEventOnce;
		public RopeBind beginBindType;
		public StringID beginBindName;
		public bool snapEnd;
		public float safeMargin;
		public bool resetOnCheckpoint;
		public bool disableAfterFadeOnRelease;
		public bool wasCut;
		public float cutLength;
		public uint cutSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					useBeginTexture = s.Serialize<bool>(useBeginTexture, name: "useBeginTexture");
					useEndTexture = s.Serialize<bool>(useEndTexture, name: "useEndTexture");
					rendererScaleMultiplier = s.Serialize<float>(rendererScaleMultiplier, name: "rendererScaleMultiplier");
					flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
					initIteration = s.Serialize<bool>(initIteration, name: "initIteration");
					ignoreStims = s.Serialize<bool>(ignoreStims, name: "ignoreStims", options: CSerializerObject.Options.BoolAsByte);
					initLenth = s.Serialize<float>(initLenth, name: "initLenth");
					force = s.Serialize<float>(force, name: "force");
					rigidConstraintFactor = s.Serialize<float>(rigidConstraintFactor, name: "rigidConstraintFactor");
					lengthFactor = s.Serialize<float>(lengthFactor, name: "lengthFactor");
					edgeLength = s.Serialize<float>(edgeLength, name: "edgeLength");
					bezierSampling = s.Serialize<uint>(bezierSampling, name: "bezierSampling");
					inverseCurveRenderer = s.Serialize<bool>(inverseCurveRenderer, name: "inverseCurveRenderer");
					fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
					onCutEvent = s.SerializeObject<Generic<Event>>(onCutEvent, name: "onCutEvent");
					sendEventOnce = s.Serialize<bool>(sendEventOnce, name: "sendEventOnce");
					beginBindType = s.Serialize<RopeBind>(beginBindType, name: "beginBindType");
					beginBindName = s.SerializeObject<StringID>(beginBindName, name: "beginBindName");
					snapEnd = s.Serialize<bool>(snapEnd, name: "snapEnd");
					safeMargin = s.Serialize<float>(safeMargin, name: "safeMargin");
					resetOnCheckpoint = s.Serialize<bool>(resetOnCheckpoint, name: "resetOnCheckpoint");
					disableAfterFadeOnRelease = s.Serialize<bool>(disableAfterFadeOnRelease, name: "disableAfterFadeOnRelease");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					wasCut = s.Serialize<bool>(wasCut, name: "wasCut");
					cutLength = s.Serialize<float>(cutLength, name: "cutLength");
					cutSender = s.Serialize<uint>(cutSender, name: "cutSender");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					useBeginTexture = s.Serialize<bool>(useBeginTexture, name: "useBeginTexture");
					useEndTexture = s.Serialize<bool>(useEndTexture, name: "useEndTexture");
					rendererScaleMultiplier = s.Serialize<float>(rendererScaleMultiplier, name: "rendererScaleMultiplier");
					flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
					initIteration = s.Serialize<bool>(initIteration, name: "initIteration");
					ignoreStims = s.Serialize<bool>(ignoreStims, name: "ignoreStims");
					initLenth = s.Serialize<float>(initLenth, name: "initLenth");
					force = s.Serialize<float>(force, name: "force");
					rigidConstraintFactor = s.Serialize<float>(rigidConstraintFactor, name: "rigidConstraintFactor");
					lengthFactor = s.Serialize<float>(lengthFactor, name: "lengthFactor");
					edgeLength = s.Serialize<float>(edgeLength, name: "edgeLength");
					bezierSampling = s.Serialize<uint>(bezierSampling, name: "bezierSampling");
					inverseCurveRenderer = s.Serialize<bool>(inverseCurveRenderer, name: "inverseCurveRenderer");
					fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
					onCutEvent = s.SerializeObject<Generic<Event>>(onCutEvent, name: "onCutEvent");
					sendEventOnce = s.Serialize<bool>(sendEventOnce, name: "sendEventOnce");
					beginBindType = s.Serialize<RopeBind>(beginBindType, name: "beginBindType");
					beginBindName = s.SerializeObject<StringID>(beginBindName, name: "beginBindName");
					snapEnd = s.Serialize<bool>(snapEnd, name: "snapEnd");
					safeMargin = s.Serialize<float>(safeMargin, name: "safeMargin");
					resetOnCheckpoint = s.Serialize<bool>(resetOnCheckpoint, name: "resetOnCheckpoint");
					disableAfterFadeOnRelease = s.Serialize<bool>(disableAfterFadeOnRelease, name: "disableAfterFadeOnRelease");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					wasCut = s.Serialize<bool>(wasCut, name: "wasCut");
					cutLength = s.Serialize<float>(cutLength, name: "cutLength");
				}
			}
		}
		public enum RopeBind {
			[Serialize("RopeBind::Root"              )] Root = 0,
			[Serialize("RopeBind::BoneName"          )] BoneName = 1,
			[Serialize("RopeBind::ProceduralBoneName")] ProceduralBoneName = 2,
		}
		public override uint? ClassCRC => 0xEA979020;
	}
}

