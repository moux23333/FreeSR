namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EDFALKDIGGP
	{
		[ProtoMember(1)] public int Slot;
		[ProtoMember(12)] public AvatarType AvatarType;
		[ProtoMember(10)] public int Id;
	}
	
}
