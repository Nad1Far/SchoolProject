def is_natural_positive(num):
    """Проверяет, является ли число натуральным положительным."""
    return isinstance(num, int) and num > 0

def find_solutions():
    """Находит все решения для (a*c + b*d) / (c*d) = натуральное число, где a, b, c, d < 20 и a != b != c != d."""
    solutions = []
    for a in range(1, 20):
        for b in range(1, 20):
            if a == b:
                continue #пропускаем если а равно б
            for c in range(1, 20):
                if c == a or c == b:
                    continue #пропускаем если с равно а или б
                for d in range(1, 20):
                    if d == a or d == b or d == c:
                        continue #пропускаем если d равно a, b или с

                    if c * d != 0:  # Избегаем деления на ноль
                        result = (a * c + b * d) / (c * d)
                        if is_natural_positive(result) and result == int(result):
                            solutions.append((a, b, c, d))
    return solutions

solutions = find_solutions()

# убираем дубликаты. Сортируем tuple чтобы они были в одинаковом порядке для сравнения
unique_solutions = []
seen = set()
for sol in solutions:
    sorted_sol = tuple(sorted(sol)) #сортируем каждый кортеж, чтобы (1,2,3,4) считалось дубликатом (4,3,2,1)
    if sorted_sol not in seen:
        unique_solutions.append(sol)
        seen.add(sorted_sol)


# Раскомментируйте следующую строку, чтобы сохранить полный список в файл, вместо печати на экран.
with open("solutions_unique.txt", "w") as f:
    for solution in unique_solutions:
        f.write(str(solution) + "\n")


print(f"Количество уникальных решений: {len(unique_solutions)}")
# Печатаем первые несколько решений и последние несколько решений для примера.
if len(unique_solutions) > 10:
    for i in range(5):
        print(unique_solutions[i])
    print("...")
    for i in range(5):
        print(unique_solutions[len(unique_solutions) - 5 + i])
else:
    for solution in unique_solutions:
        print(solution)

print("Полный список сохранен в файл solutions_unique.txt (раскомментируйте код)")