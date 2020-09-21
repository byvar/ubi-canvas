using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_DispenserComponent_Template : ActorComponent_Template {
		public uint goodsCount;
		public uint lowLifeGoodsMax;
		public float lowLifeThreshold;
		public float dispenseDelay;
		public float shakeDelay;
		public Vec3d spawnOffset;
		public CArrayO<Angle> ejectionAngleList;
		public int isChildLauncher;
		public StringID animIdle;
		public int canWiggle;
		public StringID padRumbleWiggle;
		public StringID animWiggle;
		public StringID animDispense;
		public StringID animShrink;
		public StringID animDone;
		public Generic<Event> dispenseEvent;
		public Generic<Event> lowLifeEvent;
		public int softCollisionDisabled;
		public Ray_SoftCollision_Template softCollision;
		public int processStim;
		public int allowNonPlayerHits;
		public int disableWhenDone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			goodsCount = s.Serialize<uint>(goodsCount, name: "goodsCount");
			lowLifeGoodsMax = s.Serialize<uint>(lowLifeGoodsMax, name: "lowLifeGoodsMax");
			lowLifeThreshold = s.Serialize<float>(lowLifeThreshold, name: "lowLifeThreshold");
			dispenseDelay = s.Serialize<float>(dispenseDelay, name: "dispenseDelay");
			shakeDelay = s.Serialize<float>(shakeDelay, name: "shakeDelay");
			spawnOffset = s.SerializeObject<Vec3d>(spawnOffset, name: "spawnOffset");
			ejectionAngleList = s.SerializeObject<CArrayO<Angle>>(ejectionAngleList, name: "ejectionAngleList");
			isChildLauncher = s.Serialize<int>(isChildLauncher, name: "isChildLauncher");
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			canWiggle = s.Serialize<int>(canWiggle, name: "canWiggle");
			padRumbleWiggle = s.SerializeObject<StringID>(padRumbleWiggle, name: "padRumbleWiggle");
			animWiggle = s.SerializeObject<StringID>(animWiggle, name: "animWiggle");
			animDispense = s.SerializeObject<StringID>(animDispense, name: "animDispense");
			animShrink = s.SerializeObject<StringID>(animShrink, name: "animShrink");
			animDone = s.SerializeObject<StringID>(animDone, name: "animDone");
			dispenseEvent = s.SerializeObject<Generic<Event>>(dispenseEvent, name: "dispenseEvent");
			lowLifeEvent = s.SerializeObject<Generic<Event>>(lowLifeEvent, name: "lowLifeEvent");
			softCollisionDisabled = s.Serialize<int>(softCollisionDisabled, name: "softCollisionDisabled");
			softCollision = s.SerializeObject<Ray_SoftCollision_Template>(softCollision, name: "softCollision");
			processStim = s.Serialize<int>(processStim, name: "processStim");
			allowNonPlayerHits = s.Serialize<int>(allowNonPlayerHits, name: "allowNonPlayerHits");
			disableWhenDone = s.Serialize<int>(disableWhenDone, name: "disableWhenDone");
		}
		public override uint? ClassCRC => 0xDE07C31D;
	}
}

