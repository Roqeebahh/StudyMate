using StudyyMate.Models;
using System.Collections.Generic;
using System.Data.SQLite;

public static class DatabaseHelper
{
    private static string _dbPath = "Data Source=studymate.db";

    public static void InitializeDatabase()
    {
        using (var conn = new SQLiteConnection(_dbPath))
        {
            conn.Open();
            var cmd = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS ProgressRecords (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT,
                    TotalHours INTEGER,
                    HoursCompleted INTEGER
                );", conn);
            cmd.ExecuteNonQuery();
        }
    }

    public static List<ProgressRecord> LoadProgress()
    {
        var records = new List<ProgressRecord>();
        using (var conn = new SQLiteConnection(_dbPath))
        {
            conn.Open();
            var cmd = new SQLiteCommand("SELECT SubjectName, TotalHours, HoursCompleted FROM ProgressRecords", conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    records.Add(new ProgressRecord
                    {
                        SubjectName = reader.GetString(0),
                        TotalHours = reader.GetInt32(1),
                        HoursCompleted = reader.GetInt32(2)
                    });
                }
            }
        }
        return records;
    }

    public static void SaveProgress(List<ProgressRecord> records)
    {
        using (var conn = new SQLiteConnection(_dbPath))
        {
            conn.Open();

            var clearCmd = new SQLiteCommand("DELETE FROM ProgressRecords", conn);
            clearCmd.ExecuteNonQuery();

            foreach (var record in records)
            {
                var insertCmd = new SQLiteCommand(
                    "INSERT INTO ProgressRecords (SubjectName, TotalHours, HoursCompleted) VALUES (@name, @total, @done)", conn);
                insertCmd.Parameters.AddWithValue("@name", record.SubjectName);
                insertCmd.Parameters.AddWithValue("@total", record.TotalHours);
                insertCmd.Parameters.AddWithValue("@done", record.HoursCompleted);
                insertCmd.ExecuteNonQuery();
            }
        }
    }
}
