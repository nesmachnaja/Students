SELECT Id FROM students
WHERE Id=(SELECT MAX(Id) FROM students)