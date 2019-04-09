using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FxDescriptor_Template : CSerializable {
		[Serialize("name"                   )] public StringID name;
		[Serialize("gen"                    )] public ITF_ParticleGenerator_Template gen;
		[Serialize("texture"                )] public Path texture;
		[Serialize("material"               )] public GFXMaterialSerializable material;
		[Serialize("angleOffset"            )] public Angle angleOffset;
		[Serialize("minDelay"               )] public float minDelay;
		[Serialize("maxDelay"               )] public float maxDelay;
		[Serialize("frequencyInput"         )] public ProceduralInputData frequencyInput;
		[Serialize("emitCountInput"         )] public ProceduralInputData emitCountInput;
		[Serialize("maxParticlesInput"      )] public ProceduralInputData maxParticlesInput;
		[Serialize("velocityInput"          )] public ProceduralInputData velocityInput;
		[Serialize("velocityDeltaInput"     )] public ProceduralInputData velocityDeltaInput;
		[Serialize("angularSpeedInput"      )] public ProceduralInputData angularSpeedInput;
		[Serialize("angularSpeedDeltaInput" )] public ProceduralInputData angularSpeedDeltaInput;
		[Serialize("defaultAlphaInput"      )] public ProceduralInputData defaultAlphaInput;
		[Serialize("draw2D"                 )] public bool draw2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(gen));
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(angleOffset), type: typeof(float));
				SerializeField(s, nameof(minDelay));
				SerializeField(s, nameof(maxDelay));
				SerializeField(s, nameof(frequencyInput));
				SerializeField(s, nameof(emitCountInput));
				SerializeField(s, nameof(velocityInput));
				SerializeField(s, nameof(velocityDeltaInput));
				SerializeField(s, nameof(angularSpeedInput));
				SerializeField(s, nameof(angularSpeedDeltaInput));
				SerializeField(s, nameof(draw2D));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(gen));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(minDelay));
				SerializeField(s, nameof(maxDelay));
				SerializeField(s, nameof(frequencyInput));
				SerializeField(s, nameof(emitCountInput));
				SerializeField(s, nameof(maxParticlesInput));
				SerializeField(s, nameof(velocityInput));
				SerializeField(s, nameof(velocityDeltaInput));
				SerializeField(s, nameof(angularSpeedInput));
				SerializeField(s, nameof(angularSpeedDeltaInput));
				SerializeField(s, nameof(defaultAlphaInput));
				SerializeField(s, nameof(draw2D));
			}
		}
	}
}

