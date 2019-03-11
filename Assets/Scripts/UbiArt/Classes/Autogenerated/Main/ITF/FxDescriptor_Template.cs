using UnityEngine;

namespace UbiArt.ITF {
	public partial class FxDescriptor_Template : CSerializable {
		[Serialize("gen"                   )] public ITF_ParticleGenerator_Template gen;
		[Serialize("texture"               )] public Path texture;
		[Serialize("material"              )] public GFXMaterialSerializable material;
		[Serialize("minDelay"              )] public float minDelay;
		[Serialize("maxDelay"              )] public float maxDelay;
		[Serialize("frequencyInput"        )] public ProceduralInputData frequencyInput;
		[Serialize("emitCountInput"        )] public ProceduralInputData emitCountInput;
		[Serialize("maxParticlesInput"     )] public ProceduralInputData maxParticlesInput;
		[Serialize("velocityInput"         )] public ProceduralInputData velocityInput;
		[Serialize("velocityDeltaInput"    )] public ProceduralInputData velocityDeltaInput;
		[Serialize("angularSpeedInput"     )] public ProceduralInputData angularSpeedInput;
		[Serialize("angularSpeedDeltaInput")] public ProceduralInputData angularSpeedDeltaInput;
		[Serialize("defaultAlphaInput"     )] public ProceduralInputData defaultAlphaInput;
		[Serialize("draw2D"                )] public bool draw2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gen));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(material));
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

