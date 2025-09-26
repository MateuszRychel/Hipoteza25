class Program:
    def __init__(self, tab):
        self.tab = tab

    def Nwd(self, a, b):
        while a != b:
            if a > b:
                a = a - b
            else:
                b = b - a
        return a

    def Algorithm(self):
        result = self.tab[0]
        for number in self.tab[1:]:
            result = self.Nwd(result, number)
        return result

numbers = [36, 24, 72, 150, 10]
Test = Program(numbers)
print(Test.Algorithm())
