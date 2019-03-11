using UnityEngine;

namespace UbiArt.ITF {
	public partial class BounceOnPolylinePhysComponent_Template : PhysComponent_Template {
		[Serialize("bouncingFactor"                )] public float bouncingFactor;
		[Serialize("bouncingMinYSpeed"             )] public float bouncingMinYSpeed;
		[Serialize("bouncingPassengerFactor"       )] public float bouncingPassengerFactor;
		[Serialize("bouncingDefaultActorWeight"    )] public float bouncingDefaultActorWeight;
		[Serialize("bouncingPunchMultiplier"       )] public float bouncingPunchMultiplier;
		[Serialize("physAngularRealignSmoothFactor")] public float physAngularRealignSmoothFactor;
		[Serialize("physRadius"                    )] public float physRadius;
		[Serialize("physWindMultiplier"            )] public float physWindMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(bouncingFactor));
				SerializeField(s, nameof(bouncingMinYSpeed));
				SerializeField(s, nameof(bouncingPassengerFactor));
				SerializeField(s, nameof(bouncingDefaultActorWeight));
				SerializeField(s, nameof(bouncingPunchMultiplier));
				SerializeField(s, nameof(physAngularRealignSmoothFactor));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bouncingFactor));
				SerializeField(s, nameof(bouncingMinYSpeed));
				SerializeField(s, nameof(bouncingPassengerFactor));
				SerializeField(s, nameof(bouncingDefaultActorWeight));
				SerializeField(s, nameof(bouncingPunchMultiplier));
				SerializeField(s, nameof(physAngularRealignSmoothFactor));
			} else {
				SerializeField(s, nameof(bouncingFactor));
				SerializeField(s, nameof(bouncingMinYSpeed));
				SerializeField(s, nameof(bouncingPassengerFactor));
				SerializeField(s, nameof(bouncingDefaultActorWeight));
				SerializeField(s, nameof(bouncingPunchMultiplier));
				SerializeField(s, nameof(physAngularRealignSmoothFactor));
				SerializeField(s, nameof(physRadius));
				SerializeField(s, nameof(physWindMultiplier));
			}
		}
		public override uint? ClassCRC => 0x18FBE896;
	}
}

