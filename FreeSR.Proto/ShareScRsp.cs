namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ShareScRsp
	{
		[ProtoMember(3)] public ItemList Reward;
		[ProtoMember(11)] public PFDBIHBKPAP AJACJCKAPPJ;
		[ProtoMember(13)] public int Retcode;
	}
	
}
