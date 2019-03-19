using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class ConvertibleBranchComponent_Template : BezierBranchComponent_Template {
		[Serialize("width"                )] public float width;
		[Serialize("attachToEnd"          )] public bool attachToEnd;
		[Serialize("tileLength"           )] public float tileLength;
		[Serialize("tileBones"            )] public CList<SpriteBone> tileBones;
		[Serialize("endLength"            )] public float endLength;
		[Serialize("endBones"             )] public CList<SpriteBone> endBones;
		[Serialize("amvPath"              )] public Path amvPath;
		[Serialize("amvMaterial"          )] public GFXMaterialSerializable amvMaterial;
		[Serialize("zOffset"              )] public float zOffset;
		[Serialize("scaleFactor"          )] public float scaleFactor;
		[Serialize("convertFromEnd"       )] public bool convertFromEnd;
		[Serialize("conversionSpeed"      )] public float conversionSpeed;
		[Serialize("convertedGameMaterial")] public Path convertedGameMaterial;
		[Serialize("conversionOffset"     )] public float conversionOffset;
		[Serialize("conversionOverlap"    )] public float conversionOverlap;
		[Serialize("elementTypes"         )] public CList<ConvertibleElement_Template> elementTypes;
		[Serialize("triggerDelay"         )] public float triggerDelay;
		[Serialize("zSegmentation"        )] public float zSegmentation;
		[Serialize("drawDebug"            )] public bool drawDebug;
		[Serialize("drawDebugAnims"       )] public bool drawDebugAnims;
		[Serialize("tileBones"            )] public Placeholder tileBones;
		[Serialize("endBones"             )] public Placeholder endBones;
		[Serialize("amvMaterial"          )] public Placeholder amvMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(attachToEnd), boolAsByte: true);
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(tileBones));
				SerializeField(s, nameof(endLength));
				SerializeField(s, nameof(endBones));
				SerializeField(s, nameof(amvPath));
				SerializeField(s, nameof(amvMaterial));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(scaleFactor));
				SerializeField(s, nameof(convertFromEnd), boolAsByte: true);
				SerializeField(s, nameof(conversionSpeed));
				SerializeField(s, nameof(convertedGameMaterial));
				SerializeField(s, nameof(conversionOffset));
				SerializeField(s, nameof(conversionOverlap));
				SerializeField(s, nameof(drawDebug), boolAsByte: true);
				SerializeField(s, nameof(drawDebugAnims), boolAsByte: true);
			} else {
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(attachToEnd));
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(tileBones));
				SerializeField(s, nameof(endLength));
				SerializeField(s, nameof(endBones));
				SerializeField(s, nameof(amvPath));
				SerializeField(s, nameof(amvMaterial));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(scaleFactor));
				SerializeField(s, nameof(convertFromEnd));
				SerializeField(s, nameof(conversionSpeed));
				SerializeField(s, nameof(convertedGameMaterial));
				SerializeField(s, nameof(conversionOffset));
				SerializeField(s, nameof(conversionOverlap));
				SerializeField(s, nameof(elementTypes));
				SerializeField(s, nameof(triggerDelay));
				SerializeField(s, nameof(zSegmentation));
				SerializeField(s, nameof(drawDebug));
				SerializeField(s, nameof(drawDebugAnims));
			}
		}
		public override uint? ClassCRC => 0x6FC0465B;
	}
}

