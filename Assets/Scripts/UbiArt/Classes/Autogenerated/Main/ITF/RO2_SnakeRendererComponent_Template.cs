using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeRendererComponent_Template : GraphicComponent_Template {
		[Serialize("bodyParts"           )] public CArray<Generic<RO2_SnakeBodyPart_Template>> bodyParts;
		[Serialize("bodyPartsZSpacing"   )] public float bodyPartsZSpacing;
		[Serialize("drawHeadBelow"       )] public bool drawHeadBelow;
		[Serialize("broadcastEventToPart")] public bool broadcastEventToPart;
		[Serialize("trajectoryOffset"    )] public float trajectoryOffset;
		[Serialize("sampleLength"        )] public float sampleLength;
		[Serialize("gameMaterial"        )] public Path gameMaterial;
		[Serialize("usePolylinePhantom"  )] public bool usePolylinePhantom;
		[Serialize("gfxMaterial"         )] public GFXMaterialSerializable gfxMaterial;
		[Serialize("amvPath"             )] public Path amvPath;
		[Serialize("fxStart"             )] public StringID fxStart;
		[Serialize("fxLoop"              )] public StringID fxLoop;
		[Serialize("fxStop"              )] public StringID fxStop;
		[Serialize("inputSpeed"          )] public StringID inputSpeed;
		[Serialize("tapPerturbator"      )] public RO2_SnakeRendererComponent_Template.Perturbator tapPerturbator;
		[Serialize("hitPerturbators"     )] public CList<RO2_SnakeRendererComponent_Template.Perturbator> hitPerturbators;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bodyParts));
			SerializeField(s, nameof(bodyPartsZSpacing));
			SerializeField(s, nameof(drawHeadBelow));
			SerializeField(s, nameof(broadcastEventToPart));
			SerializeField(s, nameof(trajectoryOffset));
			SerializeField(s, nameof(sampleLength));
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(usePolylinePhantom));
			SerializeField(s, nameof(gfxMaterial));
			SerializeField(s, nameof(amvPath));
			SerializeField(s, nameof(fxStart));
			SerializeField(s, nameof(fxLoop));
			SerializeField(s, nameof(fxStop));
			SerializeField(s, nameof(inputSpeed));
			SerializeField(s, nameof(tapPerturbator));
			SerializeField(s, nameof(hitPerturbators));
		}
		[Games(GameFlags.RA)]
		public partial class Perturbator : CSerializable {
			[Serialize("range"    )] public uint range;
			[Serialize("duration" )] public float duration;
			[Serialize("amplitude")] public float amplitude;
			[Serialize("frequency")] public float frequency;
			[Serialize("fx"       )] public StringID fx;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(range));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(amplitude));
				SerializeField(s, nameof(frequency));
				SerializeField(s, nameof(fx));
			}
		}
		public override uint? ClassCRC => 0x4E721589;
	}
}

