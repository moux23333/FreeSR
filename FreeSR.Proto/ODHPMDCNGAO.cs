namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ODHPMDCNGAO
	{
		[ProtoMember(7)] public int Id;
		[ProtoMember(12)] public AvatarType AvatarType;
		[ProtoMember(10)] public int Slot;
	}

}
