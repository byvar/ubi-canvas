using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class ParticleGeneratorComponent_Template : GraphicComponent_Template {
		[Serialize("ParticleGeneratorParams")] public ITF_ParticleGenerator_Template ParticleGeneratorParams;
		[Serialize("startTime"              )] public float startTime;
		[Serialize("stopTime"               )] public float stopTime;
		[Serialize("texture"                )] public Path texture;
		[Serialize("material"               )] public GFXMaterialSerializable material;
		[Serialize("beginStart"             )] public bool beginStart;
		[Serialize("inputs"                 )] public CList<InputDesc> inputs;
		[Serialize("frequencyInput"         )] public ProceduralInputData frequencyInput;
		[Serialize("emitCountInput"         )] public ProceduralInputData emitCountInput;
		[Serialize("maxParticlesInput"      )] public ProceduralInputData maxParticlesInput;
		[Serialize("float__0"               )] public float float__0;
		[Serialize("float__1"               )] public float float__1;
		[Serialize("Path__2"                )] public Path Path__2;
		[Serialize("int__3"                 )] public int int__3;
		[Serialize("CArray<InputDesc>__4"   )] public CArray<InputDesc> CArray_InputDesc__4;
		[Serialize("ProceduralInputData__5" )] public ProceduralInputData ProceduralInputData__5;
		[Serialize("ProceduralInputData__6" )] public ProceduralInputData ProceduralInputData__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(Path__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(CArray_InputDesc__4));
				SerializeField(s, nameof(ProceduralInputData__5));
				SerializeField(s, nameof(ProceduralInputData__6));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ParticleGeneratorParams));
				SerializeField(s, nameof(startTime));
				SerializeField(s, nameof(stopTime));
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(beginStart));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(frequencyInput));
				SerializeField(s, nameof(emitCountInput));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(ParticleGeneratorParams));
				SerializeField(s, nameof(startTime));
				SerializeField(s, nameof(stopTime));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(beginStart), boolAsByte: true);
				SerializeField(s, nameof(frequencyInput));
				SerializeField(s, nameof(emitCountInput));
				SerializeField(s, nameof(maxParticlesInput));
			} else {
				SerializeField(s, nameof(ParticleGeneratorParams));
				SerializeField(s, nameof(startTime));
				SerializeField(s, nameof(stopTime));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(beginStart));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(frequencyInput));
				SerializeField(s, nameof(emitCountInput));
				SerializeField(s, nameof(maxParticlesInput));
			}
		}
		public override uint? ClassCRC => 0xEF03E2F5;
	}
}

