namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EquipRelic
	{
		[ProtoMember(12)] public int RelicUniqueId;
		[ProtoMember(10)] public int Type;
	}
	
}
