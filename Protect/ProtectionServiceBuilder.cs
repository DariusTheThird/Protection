using Cnb.Platform.Extensions.MvcBase.Common;

namespace Protect;

public class ProtectionServiceBuilder
{
	public string DesEncryptionKey { get; set; } = "4d89g13j4j91j27c582ji693=VQ1245nb";
	public string AesEncryptionKey { get; set; } = "1eWQH34KjBfgPV48";

	public IProtectionService Build() => new DefaultDataEncryptionService(DesEncryptionKey, AesEncryptionKey);
}