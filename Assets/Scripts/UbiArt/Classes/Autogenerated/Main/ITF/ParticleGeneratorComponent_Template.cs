using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class ParticleGeneratorComponent_Template : GraphicComponent_Template {
		public ITF_ParticleGenerator_Template ParticleGeneratorParams;
		public float startTime;
		public float stopTime;
		public Path texture;
		public GFXMaterialSerializable material;
		public bool beginStart;
		public CListO<InputDesc> inputs;
		public ProceduralInputData frequencyInput;
		public ProceduralInputData emitCountInput;
		public ProceduralInputData maxParticlesInput;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				ParticleGeneratorParams = s.SerializeObject<ITF_ParticleGenerator_Template>(ParticleGeneratorParams, name: "ParticleGeneratorParams");
				startTime = s.Serialize<float>(startTime, name: "startTime");
				stopTime = s.Serialize<float>(stopTime, name: "stopTime");
				texture = s.SerializeObject<Path>(texture, name: "texture");
				beginStart = s.Serialize<bool>(beginStart, name: "beginStart");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				frequencyInput = s.SerializeObject<ProceduralInputData>(frequencyInput, name: "frequencyInput");
				emitCountInput = s.SerializeObject<ProceduralInputData>(emitCountInput, name: "emitCountInput");
			} else if (Settings.s.game == Settings.Game.COL) {
				ParticleGeneratorParams = s.SerializeObject<ITF_ParticleGenerator_Template>(ParticleGeneratorParams, name: "ParticleGeneratorParams");
				startTime = s.Serialize<float>(startTime, name: "startTime");
				stopTime = s.Serialize<float>(stopTime, name: "stopTime");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				beginStart = s.Serialize<bool>(beginStart, name: "beginStart", options: CSerializerObject.Options.BoolAsByte);
				frequencyInput = s.SerializeObject<ProceduralInputData>(frequencyInput, name: "frequencyInput");
				emitCountInput = s.SerializeObject<ProceduralInputData>(emitCountInput, name: "emitCountInput");
				maxParticlesInput = s.SerializeObject<ProceduralInputData>(maxParticlesInput, name: "maxParticlesInput");
			} else {
				ParticleGeneratorParams = s.SerializeObject<ITF_ParticleGenerator_Template>(ParticleGeneratorParams, name: "ParticleGeneratorParams");
				startTime = s.Serialize<float>(startTime, name: "startTime");
				stopTime = s.Serialize<float>(stopTime, name: "stopTime");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				beginStart = s.Serialize<bool>(beginStart, name: "beginStart");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				frequencyInput = s.SerializeObject<ProceduralInputData>(frequencyInput, name: "frequencyInput");
				emitCountInput = s.SerializeObject<ProceduralInputData>(emitCountInput, name: "emitCountInput");
				maxParticlesInput = s.SerializeObject<ProceduralInputData>(maxParticlesInput, name: "maxParticlesInput");
			}
		}
		public override uint? ClassCRC => 0xEF03E2F5;
	}
}

