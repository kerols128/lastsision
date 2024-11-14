-- Create the Department table
CREATE TABLE Department (
    Department_Id INT PRIMARY KEY identity(1,1),
    Names NVARCHAR(100) NOT NULL
);

-- Create the Student table with a foreign key reference to Department
CREATE TABLE Student (
    ID INT PRIMARY KEY identity(1,1),
    Names NVARCHAR(100) NOT NULL UNIQUE,
    Passwords NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Addres NVARCHAR(255),
    Age INT,
    DepId INT,
    FOREIGN KEY (DepId) REFERENCES Department(Department_Id)
);

-- Insert sample data into the Department table
INSERT INTO Department (Names) VALUES ( 'Computer Science');
INSERT INTO Department ( Names) VALUES ( 'Mathematics');
INSERT INTO Department ( Names) VALUES ( 'Physics');

-- Insert sample data into the Student table
INSERT INTO Student ( Names, Passwords, Email, Addres, Age, DepId) 
VALUES ( 'Alice', 'password123', 'alice@example.com', '123 Main St', 20, 1);

INSERT INTO Student ( Names, Passwords, Email, Addres, Age, DepId) 
VALUES ( 'Bob', 'password456', 'bob@example.com', '456 Elm St', 22, 2);

INSERT INTO Student ( Names, Passwords, Email, Addres, Age, DepId) 
VALUES ( 'Charlie', 'password789', 'charlie@example.com', '789 Oak St', 21, 1);
