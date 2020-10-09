using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DispenserComponent_Template : ActorComponent_Template {
		public uint goodsCount;
		public uint lowLifeGoodsMax;
		public float lowLifeThreshold;
		public float dispenseDelay;
		public float shakeDelay;
		public Vec3d spawnOffset;
		public bool isChildLauncher;
		public StringID animIdle;
		public bool canWiggle;
		public StringID padRumbleWiggle;
		public StringID animWiggle;
		public StringID animDispense;
		public StringID animShrink;
		public StringID animDone;
		public StringID animPaint;
		public Generic<Event> dispenseEvent;
		public Generic<Event> dispenseEventPaint;
		public Generic<Event> lowLifeEvent;
		public bool softCollisionDisabled;
		public RO2_SoftCollision_Template softCollision;
		public bool processStim;
		public bool processDRCStim;
		public bool allowNonPlayerHits;
		public bool disableWhenDone;
		public StringID fxStandPaint;
		public CListO<Angle> ejectionAngleList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				goodsCount = s.Serialize<uint>(goodsCount, name: "goodsCount");
				lowLifeGoodsMax = s.Serialize<uint>(lowLifeGoodsMax, name: "lowLifeGoodsMax");
				lowLifeThreshold = s.Serialize<float>(lowLifeThreshold, name: "lowLifeThreshold");
				dispenseDelay = s.Serialize<float>(dispenseDelay, name: "dispenseDelay");
				shakeDelay = s.Serialize<float>(shakeDelay, name: "shakeDelay");
				spawnOffset = s.SerializeObject<Vec3d>(spawnOffset, name: "spawnOffset");
				ejectionAngleList = s.SerializeObject<CListO<Angle>>(ejectionAngleList, name: "ejectionAngleList");
				isChildLauncher = s.Serialize<bool>(isChildLauncher, name: "isChildLauncher");
				animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
				canWiggle = s.Serialize<bool>(canWiggle, name: "canWiggle");
				padRumbleWiggle = s.SerializeObject<StringID>(padRumbleWiggle, name: "padRumbleWiggle");
				animWiggle = s.SerializeObject<StringID>(animWiggle, name: "animWiggle");
				animDispense = s.SerializeObject<StringID>(animDispense, name: "animDispense");
				animShrink = s.SerializeObject<StringID>(animShrink, name: "animShrink");
				animDone = s.SerializeObject<StringID>(animDone, name: "animDone");
				animPaint = s.SerializeObject<StringID>(animPaint, name: "animPaint");
				dispenseEvent = s.SerializeObject<Generic<Event>>(dispenseEvent, name: "dispenseEvent");
				dispenseEventPaint = s.SerializeObject<Generic<Event>>(dispenseEventPaint, name: "dispenseEventPaint");
				lowLifeEvent = s.SerializeObject<Generic<Event>>(lowLifeEvent, name: "lowLifeEvent");
				softCollisionDisabled = s.Serialize<bool>(softCollisionDisabled, name: "softCollisionDisabled");
				softCollision = s.SerializeObject<RO2_SoftCollision_Template>(softCollision, name: "softCollision");
				processStim = s.Serialize<bool>(processStim, name: "processStim");
				processDRCStim = s.Serialize<bool>(processDRCStim, name: "processDRCStim");
				allowNonPlayerHits = s.Serialize<bool>(allowNonPlayerHits, name: "allowNonPlayerHits");
				disableWhenDone = s.Serialize<bool>(disableWhenDone, name: "disableWhenDone");
				fxStandPaint = s.SerializeObject<StringID>(fxStandPaint, name: "fxStandPaint");
			} else {
				goodsCount = s.Serialize<uint>(goodsCount, name: "goodsCount");
				lowLifeGoodsMax = s.Serialize<uint>(lowLifeGoodsMax, name: "lowLifeGoodsMax");
				lowLifeThreshold = s.Serialize<float>(lowLifeThreshold, name: "lowLifeThreshold");
				dispenseDelay = s.Serialize<float>(dispenseDelay, name: "dispenseDelay");
				shakeDelay = s.Serialize<float>(shakeDelay, name: "shakeDelay");
				spawnOffset = s.SerializeObject<Vec3d>(spawnOffset, name: "spawnOffset");
				isChildLauncher = s.Serialize<bool>(isChildLauncher, name: "isChildLauncher");
				animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
				canWiggle = s.Serialize<bool>(canWiggle, name: "canWiggle");
				padRumbleWiggle = s.SerializeObject<StringID>(padRumbleWiggle, name: "padRumbleWiggle");
				animWiggle = s.SerializeObject<StringID>(animWiggle, name: "animWiggle");
				animDispense = s.SerializeObject<StringID>(animDispense, name: "animDispense");
				animShrink = s.SerializeObject<StringID>(animShrink, name: "animShrink");
				animDone = s.SerializeObject<StringID>(animDone, name: "animDone");
				animPaint = s.SerializeObject<StringID>(animPaint, name: "animPaint");
				dispenseEvent = s.SerializeObject<Generic<Event>>(dispenseEvent, name: "dispenseEvent");
				dispenseEventPaint = s.SerializeObject<Generic<Event>>(dispenseEventPaint, name: "dispenseEventPaint");
				lowLifeEvent = s.SerializeObject<Generic<Event>>(lowLifeEvent, name: "lowLifeEvent");
				softCollisionDisabled = s.Serialize<bool>(softCollisionDisabled, name: "softCollisionDisabled");
				softCollision = s.SerializeObject<RO2_SoftCollision_Template>(softCollision, name: "softCollision");
				processStim = s.Serialize<bool>(processStim, name: "processStim");
				processDRCStim = s.Serialize<bool>(processDRCStim, name: "processDRCStim");
				allowNonPlayerHits = s.Serialize<bool>(allowNonPlayerHits, name: "allowNonPlayerHits");
				disableWhenDone = s.Serialize<bool>(disableWhenDone, name: "disableWhenDone");
				fxStandPaint = s.SerializeObject<StringID>(fxStandPaint, name: "fxStandPaint");
			}
		}
		public override uint? ClassCRC => 0x53F1479E;
	}
}

