using UnityEngine;

namespace UbiArt.ITF {
	public partial class PolylineParameters : CSerializable {
		[Serialize("speedLoss"          )] public float speedLoss;
		[Serialize("weightMultiplier"   )] public float weightMultiplier;
		[Serialize("landSpeedMultiplier")] public float landSpeedMultiplier;
		[Serialize("hitForceMultiplier" )] public float hitForceMultiplier;
		[Serialize("impulseMultiplier"  )] public float impulseMultiplier;
		[Serialize("windMultiplier"     )] public float windMultiplier;
		[Serialize("gameMaterial"       )] public Path gameMaterial;
		[Serialize("environment"        )] public bool environment;
		[Serialize("usePhantom"         )] public bool usePhantom;
		[Serialize("useMovingPolyline"  )] public bool useMovingPolyline;
		[Serialize("regionType"         )] public StringID regionType;
		[Serialize("forceNoBlockHit"    )] public bool forceNoBlockHit;
		[Serialize("polylines"          )] public CList<StringID> polylines;
		[Serialize("points"             )] public CList<StringID> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speedLoss));
			SerializeField(s, nameof(weightMultiplier));
			SerializeField(s, nameof(landSpeedMultiplier));
			SerializeField(s, nameof(hitForceMultiplier));
			SerializeField(s, nameof(impulseMultiplier));
			SerializeField(s, nameof(windMultiplier));
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(environment));
			SerializeField(s, nameof(usePhantom));
			SerializeField(s, nameof(useMovingPolyline));
			SerializeField(s, nameof(regionType));
			SerializeField(s, nameof(forceNoBlockHit));
			SerializeField(s, nameof(polylines));
			SerializeField(s, nameof(points));
		}
	}
}

