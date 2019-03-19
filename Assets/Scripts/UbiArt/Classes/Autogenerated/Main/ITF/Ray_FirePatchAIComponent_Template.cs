using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_FirePatchAIComponent_Template : GraphicComponent_Template {
		[Serialize("sidePatchLength"      )] public float sidePatchLength;
		[Serialize("sidePatchWidth"       )] public float sidePatchWidth;
		[Serialize("spaceMinBetween2Start")] public float spaceMinBetween2Start;
		[Serialize("spaceMaxBetween2Start")] public float spaceMaxBetween2Start;
		[Serialize("offsetMin"            )] public float offsetMin;
		[Serialize("offsetMax"            )] public float offsetMax;
		[Serialize("scaleMin"             )] public float scaleMin;
		[Serialize("scaleMax"             )] public float scaleMax;
		[Serialize("modTileMin"           )] public uint modTileMin;
		[Serialize("modTileMax"           )] public uint modTileMax;
		[Serialize("openSpeed"            )] public float openSpeed;
		[Serialize("startOpen"            )] public uint startOpen;
		[Serialize("endOpen"              )] public uint endOpen;
		[Serialize("startLoop"            )] public uint startLoop;
		[Serialize("endLoop"              )] public uint endLoop;
		[Serialize("startClose"           )] public uint startClose;
		[Serialize("endClose"             )] public uint endClose;
		[Serialize("smokeStartOpen"       )] public uint smokeStartOpen;
		[Serialize("smokeEndOpen"         )] public uint smokeEndOpen;
		[Serialize("smokeStartLoop"       )] public uint smokeStartLoop;
		[Serialize("smokeEndLoop"         )] public uint smokeEndLoop;
		[Serialize("smokeStartClose"      )] public uint smokeStartClose;
		[Serialize("smokeEndClose"        )] public uint smokeEndClose;
		[Serialize("useSmoke"             )] public int useSmoke;
		[Serialize("smokeForwardOffset"   )] public float smokeForwardOffset;
		[Serialize("smokeBackwardOffset"  )] public float smokeBackwardOffset;
		[Serialize("textureSide"          )] public Path textureSide;
		[Serialize("textureSmoke"         )] public Path textureSmoke;
		[Serialize("tessellationLength"   )] public float tessellationLength;
		[Serialize("faction"              )] public uint faction;
		[Serialize("stimBezierLength"     )] public float stimBezierLength;
		[Serialize("stimBezierWidth"      )] public float stimBezierWidth;
		[Serialize("distSafeHead"         )] public float distSafeHead;
		[Serialize("stimOffsetTail"       )] public float stimOffsetTail;
		[Serialize("sideMode"             )] public uint sideMode;
		[Serialize("zOffset"              )] public float zOffset;
		[Serialize("startMarker"          )] public StringID startMarker;
		[Serialize("stopMarker"           )] public StringID stopMarker;
		[Serialize("stopOnHitSuccessful"  )] public int stopOnHitSuccessful;
		[Serialize("stopDeployOnStop"     )] public int stopDeployOnStop;
		[Serialize("useOptimAABB"         )] public int useOptimAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sidePatchLength));
			SerializeField(s, nameof(sidePatchWidth));
			SerializeField(s, nameof(spaceMinBetween2Start));
			SerializeField(s, nameof(spaceMaxBetween2Start));
			SerializeField(s, nameof(offsetMin));
			SerializeField(s, nameof(offsetMax));
			SerializeField(s, nameof(scaleMin));
			SerializeField(s, nameof(scaleMax));
			SerializeField(s, nameof(modTileMin));
			SerializeField(s, nameof(modTileMax));
			SerializeField(s, nameof(openSpeed));
			SerializeField(s, nameof(startOpen));
			SerializeField(s, nameof(endOpen));
			SerializeField(s, nameof(startLoop));
			SerializeField(s, nameof(endLoop));
			SerializeField(s, nameof(startClose));
			SerializeField(s, nameof(endClose));
			SerializeField(s, nameof(smokeStartOpen));
			SerializeField(s, nameof(smokeEndOpen));
			SerializeField(s, nameof(smokeStartLoop));
			SerializeField(s, nameof(smokeEndLoop));
			SerializeField(s, nameof(smokeStartClose));
			SerializeField(s, nameof(smokeEndClose));
			SerializeField(s, nameof(useSmoke));
			SerializeField(s, nameof(smokeForwardOffset));
			SerializeField(s, nameof(smokeBackwardOffset));
			SerializeField(s, nameof(textureSide));
			SerializeField(s, nameof(textureSmoke));
			SerializeField(s, nameof(tessellationLength));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(stimBezierLength));
			SerializeField(s, nameof(stimBezierWidth));
			SerializeField(s, nameof(distSafeHead));
			SerializeField(s, nameof(stimOffsetTail));
			SerializeField(s, nameof(sideMode));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(startMarker));
			SerializeField(s, nameof(stopMarker));
			SerializeField(s, nameof(stopOnHitSuccessful));
			SerializeField(s, nameof(stopDeployOnStop));
			SerializeField(s, nameof(useOptimAABB));
		}
		public override uint? ClassCRC => 0x60E0FBFC;
	}
}

