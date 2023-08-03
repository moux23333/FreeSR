namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetGameplayBirthdayScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(10)] public int Birthday;
	}
	
}
