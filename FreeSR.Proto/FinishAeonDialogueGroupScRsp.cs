namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishAeonDialogueGroupScRsp
	{
		[ProtoMember(4)] public EOEIGMPKAAO HOPLGKPJOBF;
		[ProtoMember(9)] public ItemList Reward;
		[ProtoMember(11)] public int Retcode;
	}
	
}
