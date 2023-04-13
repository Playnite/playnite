using System.IO;

namespace Playnite.Tests;

[TestFixture]
public class BackupTests
{
    [Test]
    public void RotatingBackupTest()
    {
        using var temp = TempDirectory.Create();

        void generateBackups()
        {
            FileSystem.CreateFile(Path.Combine(temp, "PlayniteBackup-2021-07-01-01-01-01.zip"));
            FileSystem.CreateFile(Path.Combine(temp, "PlayniteBackup-2021-07-02-01-01-01.zip"));
            FileSystem.CreateFile(Path.Combine(temp, "PlayniteBackup-2021-07-03-01-01-01.zip"));
        }

        var settings = new PlayniteSettings
        {
            RotatingBackups = 0,
            AutoBackupEnabled = true,
            AutoBackupDir = temp,
            AutoBackupIncludeExtensions = true,
            AutoBackupIncludeExtensionsData = true,
            AutoBackupIncludeLibFiles = true,
            AutoBackupIncludeThemes = true
        };

        // No rotating file
        var backupOptions = Backup.GetAutoBackupOptions(settings, temp, Path.Combine(temp, "lib"));
        generateBackups();
        Backup.BackupData(backupOptions, CancellationToken.None);

        var backups = Directory.GetFiles(temp);
        Assert.AreEqual(1, backups.Length);
        StringAssert.AreEqualIgnoringCase(backupOptions.OutputFile, backups[0]);

        // Rotating files: less than existing backups
        backupOptions.RotatingBackups = 1;
        generateBackups();
        Backup.BackupData(backupOptions, CancellationToken.None);

        backups = Directory.GetFiles(temp);
        Assert.AreEqual(2, backups.Length);
        StringAssert.AreEqualIgnoringCase(backupOptions.OutputFile, backups[1]);

        // Rotating files: exact to existing backups
        backupOptions.RotatingBackups = 3;
        generateBackups();
        Backup.BackupData(backupOptions, CancellationToken.None);

        backups = Directory.GetFiles(temp);
        Assert.AreEqual(4, backups.Length);
        StringAssert.AreEqualIgnoringCase(backupOptions.OutputFile, backups[3]);

        // Rotating files: more than existing backups
        backupOptions.RotatingBackups = 10;
        generateBackups();
        Backup.BackupData(backupOptions, CancellationToken.None);

        backups = Directory.GetFiles(temp);
        Assert.AreEqual(4, backups.Length);
        StringAssert.AreEqualIgnoringCase(backupOptions.OutputFile, backups[3]);
    }
}
