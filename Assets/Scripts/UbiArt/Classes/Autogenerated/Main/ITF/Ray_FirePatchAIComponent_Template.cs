using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_FirePatchAIComponent_Template : GraphicComponent_Template {
		public float sidePatchLength;
		public float sidePatchWidth;
		public float spaceMinBetween2Start;
		public float spaceMaxBetween2Start;
		public float offsetMin;
		public float offsetMax;
		public float scaleMin;
		public float scaleMax;
		public uint modTileMin;
		public uint modTileMax;
		public float openSpeed;
		public uint startOpen;
		public uint endOpen;
		public uint startLoop;
		public uint endLoop;
		public uint startClose;
		public uint endClose;
		public uint smokeStartOpen;
		public uint smokeEndOpen;
		public uint smokeStartLoop;
		public uint smokeEndLoop;
		public uint smokeStartClose;
		public uint smokeEndClose;
		public int useSmoke;
		public float smokeForwardOffset;
		public float smokeBackwardOffset;
		public Path textureSide;
		public Path textureSmoke;
		public float tessellationLength;
		public uint faction;
		public float stimBezierLength;
		public float stimBezierWidth;
		public float distSafeHead;
		public float stimOffsetTail;
		public uint sideMode;
		public float zOffset;
		public StringID startMarker;
		public StringID stopMarker;
		public int stopOnHitSuccessful;
		public int stopDeployOnStop;
		public int useOptimAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sidePatchLength = s.Serialize<float>(sidePatchLength, name: "sidePatchLength");
			sidePatchWidth = s.Serialize<float>(sidePatchWidth, name: "sidePatchWidth");
			spaceMinBetween2Start = s.Serialize<float>(spaceMinBetween2Start, name: "spaceMinBetween2Start");
			spaceMaxBetween2Start = s.Serialize<float>(spaceMaxBetween2Start, name: "spaceMaxBetween2Start");
			offsetMin = s.Serialize<float>(offsetMin, name: "offsetMin");
			offsetMax = s.Serialize<float>(offsetMax, name: "offsetMax");
			scaleMin = s.Serialize<float>(scaleMin, name: "scaleMin");
			scaleMax = s.Serialize<float>(scaleMax, name: "scaleMax");
			modTileMin = s.Serialize<uint>(modTileMin, name: "modTileMin");
			modTileMax = s.Serialize<uint>(modTileMax, name: "modTileMax");
			openSpeed = s.Serialize<float>(openSpeed, name: "openSpeed");
			startOpen = s.Serialize<uint>(startOpen, name: "startOpen");
			endOpen = s.Serialize<uint>(endOpen, name: "endOpen");
			startLoop = s.Serialize<uint>(startLoop, name: "startLoop");
			endLoop = s.Serialize<uint>(endLoop, name: "endLoop");
			startClose = s.Serialize<uint>(startClose, name: "startClose");
			endClose = s.Serialize<uint>(endClose, name: "endClose");
			smokeStartOpen = s.Serialize<uint>(smokeStartOpen, name: "smokeStartOpen");
			smokeEndOpen = s.Serialize<uint>(smokeEndOpen, name: "smokeEndOpen");
			smokeStartLoop = s.Serialize<uint>(smokeStartLoop, name: "smokeStartLoop");
			smokeEndLoop = s.Serialize<uint>(smokeEndLoop, name: "smokeEndLoop");
			smokeStartClose = s.Serialize<uint>(smokeStartClose, name: "smokeStartClose");
			smokeEndClose = s.Serialize<uint>(smokeEndClose, name: "smokeEndClose");
			useSmoke = s.Serialize<int>(useSmoke, name: "useSmoke");
			smokeForwardOffset = s.Serialize<float>(smokeForwardOffset, name: "smokeForwardOffset");
			smokeBackwardOffset = s.Serialize<float>(smokeBackwardOffset, name: "smokeBackwardOffset");
			textureSide = s.SerializeObject<Path>(textureSide, name: "textureSide");
			textureSmoke = s.SerializeObject<Path>(textureSmoke, name: "textureSmoke");
			tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
			faction = s.Serialize<uint>(faction, name: "faction");
			stimBezierLength = s.Serialize<float>(stimBezierLength, name: "stimBezierLength");
			stimBezierWidth = s.Serialize<float>(stimBezierWidth, name: "stimBezierWidth");
			distSafeHead = s.Serialize<float>(distSafeHead, name: "distSafeHead");
			stimOffsetTail = s.Serialize<float>(stimOffsetTail, name: "stimOffsetTail");
			sideMode = s.Serialize<uint>(sideMode, name: "sideMode");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			startMarker = s.SerializeObject<StringID>(startMarker, name: "startMarker");
			stopMarker = s.SerializeObject<StringID>(stopMarker, name: "stopMarker");
			stopOnHitSuccessful = s.Serialize<int>(stopOnHitSuccessful, name: "stopOnHitSuccessful");
			stopDeployOnStop = s.Serialize<int>(stopDeployOnStop, name: "stopDeployOnStop");
			useOptimAABB = s.Serialize<int>(useOptimAABB, name: "useOptimAABB");
		}
		public override uint? ClassCRC => 0x60E0FBFC;
	}
}

