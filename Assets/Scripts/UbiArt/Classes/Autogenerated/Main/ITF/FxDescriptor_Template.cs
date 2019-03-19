using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
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
		[Serialize("StringID__0"            )] public StringID StringID__0;
		[Serialize("Path__1"                )] public Path Path__1;
		[Serialize("float__2"               )] public float float__2;
		[Serialize("float__3"               )] public float float__3;
		[Serialize("float__4"               )] public float float__4;
		[Serialize("ProceduralInputData__5" )] public ProceduralInputData ProceduralInputData__5;
		[Serialize("ProceduralInputData__6" )] public ProceduralInputData ProceduralInputData__6;
		[Serialize("ProceduralInputData__7" )] public ProceduralInputData ProceduralInputData__7;
		[Serialize("ProceduralInputData__8" )] public ProceduralInputData ProceduralInputData__8;
		[Serialize("ProceduralInputData__9" )] public ProceduralInputData ProceduralInputData__9;
		[Serialize("ProceduralInputData__10")] public ProceduralInputData ProceduralInputData__10;
		[Serialize("int__11"                )] public int int__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(Path__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(ProceduralInputData__5));
				SerializeField(s, nameof(ProceduralInputData__6));
				SerializeField(s, nameof(ProceduralInputData__7));
				SerializeField(s, nameof(ProceduralInputData__8));
				SerializeField(s, nameof(ProceduralInputData__9));
				SerializeField(s, nameof(ProceduralInputData__10));
				SerializeField(s, nameof(int__11));
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

