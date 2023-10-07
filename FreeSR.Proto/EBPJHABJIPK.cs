namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EBPJHABJIPK
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(6)] public ItemList Reward;
		[ProtoMember(15)] public int Level;
	}

}
