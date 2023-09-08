namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RAVersion)]
	public partial class RopeComponent : GraphicComponent {
		public bool useBeginTexture = true;
		public bool useEndTexture = true;
		public float rendererScaleMultiplier = 1f;
		public bool flipTexture;
		public bool initIteration;
		public bool ignoreStims;
		public float initLenth = 10f;
		public float force = 300f;
		public float rigidConstraintFactor = 0.8f;
		public float lengthFactor = 1f;
		public float edgeLength = 1f;
		public uint bezierSampling = 1;
		public bool inverseCurveRenderer;
		public float fadeTime = 1.3f;
		public Generic<Event> onCutEvent;
		public bool sendEventOnce;
		public RopeBind beginBindType;
		public StringID beginBindName;
		public bool snapEnd = true;
		public float safeMargin;
		public bool resetOnCheckpoint;
		public bool disableAfterFadeOnRelease;
		public bool wasCut;
		public float cutLength = 1f;
		public uint cutSender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
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
		public override uint? ClassCRC => 0x23302B8F;
	}
}

