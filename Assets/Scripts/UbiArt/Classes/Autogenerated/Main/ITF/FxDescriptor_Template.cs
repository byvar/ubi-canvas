using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FxDescriptor_Template : CSerializable {
		public StringID name;
		public ITF_ParticleGenerator_Template gen;
		public Path texture;
		public GFXMaterialSerializable material;
		public Angle angleOffset;
		public float minDelay;
		public float maxDelay;
		public ProceduralInputData frequencyInput;
		public ProceduralInputData emitCountInput;
		public ProceduralInputData maxParticlesInput;
		public ProceduralInputData velocityInput;
		public ProceduralInputData velocityDeltaInput;
		public ProceduralInputData angularSpeedInput;
		public ProceduralInputData angularSpeedDeltaInput;
		public ProceduralInputData defaultAlphaInput;
		public bool draw2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR) {
				name = s.SerializeObject<StringID>(name, name: "name");
				gen = s.SerializeObject<ITF_ParticleGenerator_Template>(gen, name: "gen");
				texture = s.SerializeObject<Path>(texture, name: "texture");
				angleOffset = (Angle)s.Serialize<float>((float)angleOffset, name: "angleOffset");
				minDelay = s.Serialize<float>(minDelay, name: "minDelay");
				maxDelay = s.Serialize<float>(maxDelay, name: "maxDelay");
				frequencyInput = s.SerializeObject<ProceduralInputData>(frequencyInput, name: "frequencyInput");
				emitCountInput = s.SerializeObject<ProceduralInputData>(emitCountInput, name: "emitCountInput");
				velocityInput = s.SerializeObject<ProceduralInputData>(velocityInput, name: "velocityInput");
				velocityDeltaInput = s.SerializeObject<ProceduralInputData>(velocityDeltaInput, name: "velocityDeltaInput");
				angularSpeedInput = s.SerializeObject<ProceduralInputData>(angularSpeedInput, name: "angularSpeedInput");
				angularSpeedDeltaInput = s.SerializeObject<ProceduralInputData>(angularSpeedDeltaInput, name: "angularSpeedDeltaInput");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				gen = s.SerializeObject<ITF_ParticleGenerator_Template>(gen, name: "gen");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
				minDelay = s.Serialize<float>(minDelay, name: "minDelay");
				maxDelay = s.Serialize<float>(maxDelay, name: "maxDelay");
				frequencyInput = s.SerializeObject<ProceduralInputData>(frequencyInput, name: "frequencyInput");
				emitCountInput = s.SerializeObject<ProceduralInputData>(emitCountInput, name: "emitCountInput");
				maxParticlesInput = s.SerializeObject<ProceduralInputData>(maxParticlesInput, name: "maxParticlesInput");
				velocityInput = s.SerializeObject<ProceduralInputData>(velocityInput, name: "velocityInput");
				velocityDeltaInput = s.SerializeObject<ProceduralInputData>(velocityDeltaInput, name: "velocityDeltaInput");
				angularSpeedInput = s.SerializeObject<ProceduralInputData>(angularSpeedInput, name: "angularSpeedInput");
				angularSpeedDeltaInput = s.SerializeObject<ProceduralInputData>(angularSpeedDeltaInput, name: "angularSpeedDeltaInput");
				defaultAlphaInput = s.SerializeObject<ProceduralInputData>(defaultAlphaInput, name: "defaultAlphaInput");
				draw2D = s.Serialize<bool>(draw2D, name: "draw2D");
			}
		}
	}
}

