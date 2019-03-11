using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_181_sub_7721F0 : CSerializable {
		[Serialize("leaderboardFocusSpeedThreshold")] public float leaderboardFocusSpeedThreshold;
		[Serialize("queryResultSize"               )] public uint queryResultSize;
		[Serialize("nodeScenePath"                 )] public Path nodeScenePath;
		[Serialize("mainNodeScenePath"             )] public Path mainNodeScenePath;
		[Serialize("maxHeight"                     )] public float maxHeight;
		[Serialize("firstNodeSpace"                )] public float firstNodeSpace;
		[Serialize("nodeSpace"                     )] public float nodeSpace;
		[Serialize("nodeSpeed"                     )] public Vector3 nodeSpeed;
		[Serialize("segmentThickness"              )] public float segmentThickness;
		[Serialize("rollOverOffset"                )] public float rollOverOffset;
		[Serialize("rollOverSize"                  )] public float rollOverSize;
		[Serialize("rollOverBlendSpeedMin"         )] public float rollOverBlendSpeedMin;
		[Serialize("rollOverBlendSpeedOffset"      )] public float rollOverBlendSpeedOffset;
		[Serialize("slideNodeCount"                )] public uint slideNodeCount;
		[Serialize("coverflowNodeCount"            )] public uint coverflowNodeCount;
		[Serialize("coverflowNodeSpace"            )] public float coverflowNodeSpace;
		[Serialize("gfxMaterial"                   )] public Placeholder gfxMaterial;
		[Serialize("startBrickPath"                )] public Path startBrickPath;
		[Serialize("endBrickPath"                  )] public Path endBrickPath;
		[Serialize("firstLeftBrickPath"            )] public Path firstLeftBrickPath;
		[Serialize("firstRightBrickPath"           )] public Path firstRightBrickPath;
		[Serialize("tilesSize"                     )] public float tilesSize;
		[Serialize("anchorLeft"                    )] public string anchorLeft;
		[Serialize("anchorRight"                   )] public string anchorRight;
		[Serialize("tilesPath"                     )] public Placeholder tilesPath;
		[Serialize("friendActorPath"               )] public Path friendActorPath;
		[Serialize("friendCountMax"                )] public uint friendCountMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leaderboardFocusSpeedThreshold));
			SerializeField(s, nameof(queryResultSize));
			SerializeField(s, nameof(nodeScenePath));
			SerializeField(s, nameof(mainNodeScenePath));
			SerializeField(s, nameof(maxHeight));
			SerializeField(s, nameof(firstNodeSpace));
			SerializeField(s, nameof(nodeSpace));
			SerializeField(s, nameof(nodeSpeed));
			SerializeField(s, nameof(segmentThickness));
			SerializeField(s, nameof(rollOverOffset));
			SerializeField(s, nameof(rollOverSize));
			SerializeField(s, nameof(rollOverBlendSpeedMin));
			SerializeField(s, nameof(rollOverBlendSpeedOffset));
			SerializeField(s, nameof(slideNodeCount));
			SerializeField(s, nameof(coverflowNodeCount));
			SerializeField(s, nameof(coverflowNodeSpace));
			SerializeField(s, nameof(gfxMaterial));
			SerializeField(s, nameof(startBrickPath));
			SerializeField(s, nameof(endBrickPath));
			SerializeField(s, nameof(firstLeftBrickPath));
			SerializeField(s, nameof(firstRightBrickPath));
			SerializeField(s, nameof(tilesSize));
			SerializeField(s, nameof(anchorLeft));
			SerializeField(s, nameof(anchorRight));
			SerializeField(s, nameof(tilesPath));
			SerializeField(s, nameof(friendActorPath));
			SerializeField(s, nameof(friendCountMax));
		}
		public override uint? ClassCRC => 0x5FA2F830;
	}
}

